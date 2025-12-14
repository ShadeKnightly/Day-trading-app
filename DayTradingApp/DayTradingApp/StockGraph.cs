using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayTradingApp {
    public partial class StockGraph : UserControl {
        private bool _loading = true;
        private MarketReport _marketReport;
        private List<MarketReport.PricePoint> _dataPoints;

        public StockGraph() {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        // Call this from within the assembly after you have a MarketReport instance and symbol
        internal async Task LoadDataAsync(MarketReport marketReport, string ticker, StockDataRange range) {
            _loading = true;
            _marketReport = marketReport;
            Invalidate();

            if (_marketReport == null) return;

            // Fetch historical data for the given ticker
            _dataPoints = await _marketReport.GetHistoricalDataAsync(ticker, range);

            _loading = false;
            Invalidate(); // trigger repaint with data
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e); 

            Graphics g = e.Graphics;
            using Pen p = new Pen(Color.LightBlue, 4);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // loading data message
            if (_loading || _dataPoints == null || _dataPoints.Count == 0) {
                g.DrawString("Loading data...", new Font("Segoe UI", 10, FontStyle.Italic),
                    Brushes.Gray, new PointF(10, 10));
                return;
            }

            // Filter out invalid points (e.g. no close price)
            var validData = _dataPoints
                .Where(pnt => !double.IsNaN(pnt.Close) && !double.IsInfinity(pnt.Close))
                .OrderBy(p => p.Date) // ensure chronological
                .ToList();
            Debug.WriteLine($"StockGraph: last point date = {validData.Last().Date:yyyy-MM-dd}");

            if (validData.Count < 2) {
                g.DrawString("Not enough data to draw graph.", new Font("Segoe UI", 10, FontStyle.Italic),
                    Brushes.Gray, new PointF(10, 10));
                return;
            }

            // Extract close prices and min/max
            var prices = validData.Select(v => v.Close).ToList();
            double min = prices.Min();
            double max = prices.Max();

            if (Math.Abs(max - min) < double.Epsilon) {
                // Avoid division by zero when all prices are the same
                max = min + 1.0;
            }

            // Cap to avoid overly dense rendering
            int maxPoints = 2500;
            if (prices.Count > maxPoints) {
                int skip = prices.Count / maxPoints;
                validData = validData.Where((x, idx) => idx % skip == 0).ToList();
                prices = validData.Select(v => v.Close).ToList();
            }

            int padding = 20;
            float chartWidth = Width - padding * 2;
            float chartHeight = Height - padding * 2;

            for (int i = 1; i < prices.Count; i++) {
                // X coordinates, spaced evenly
                float x1 = padding + (i - 1) * (chartWidth / prices.Count);
                float x2 = padding + i * (chartWidth / prices.Count);

                // Y coordinates, inverted (higher price -> lower Y)
                float y1 = padding + (float)(chartHeight - ((prices[i - 1] - min) / (max - min) * chartHeight));
                float y2 = padding + (float)(chartHeight - ((prices[i] - min) / (max - min) * chartHeight));

                g.DrawLine(p, x1, y1, x2, y2);

                // If this is the last point, draw the final dot and price label
                if (i == prices.Count - 1) {
                    g.FillEllipse(Brushes.LightBlue, x2 - 5, y2 - 5, 10, 10);

                    // always use the last element from validData for the label
                    var lastPoint = validData[validData.Count - 1];
                    double lastPrice = prices[prices.Count - 1];

                    string priceLabel = $"${lastPrice:F2} ({lastPoint.Date:MMM dd, yyyy})";

                    using Font labelFont = new Font("Imprint MT Shadow", 10, FontStyle.Bold);
                    SizeF labelSize = g.MeasureString(priceLabel, labelFont);

                    // Default position slightly above the point
                    float labelX = x2 - labelSize.Width / 2;
                    float labelY = y2 - labelSize.Height - 10;

                    // Keep inside chart bounds
                    if (labelX + labelSize.Width > Width - 10)
                        labelX = Width - labelSize.Width - 10;
                    if (labelX < 10)
                        labelX = 10;
                    if (labelY < 10)
                        labelY = y2 + 15; // move below if too close to top

                    g.DrawString(priceLabel, labelFont, Brushes.White, labelX, labelY);
                }
            }
        }
    }
}
