using System.Windows.Forms;

namespace DayTradingApp.Components
{
    partial class allStocksControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableHeaderPanel = new TableLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            dgvStocks = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnFilter = new Button();
            watchlistLabel = new Label();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStocks).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control;
            tableLayoutPanel4.BackgroundImage = Properties.Resources.square;
            tableLayoutPanel4.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(39, 38, 39, 38);
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.75862F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 87.24138F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel4.Size = new System.Drawing.Size(894, 514);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 13F));
            tableLayoutPanel5.Controls.Add(tableHeaderPanel, 0, 0);
            tableLayoutPanel5.Controls.Add(dgvStocks, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(41, 95);
            tableLayoutPanel5.Margin = new Padding(2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(16, 0, 16, 0);
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new System.Drawing.Size(812, 379);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // tableHeaderPanel
            // 
            tableHeaderPanel.ColumnCount = 5;
            tableHeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableHeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableHeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
            tableHeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableHeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableHeaderPanel.Controls.Add(label6, 4, 0);
            tableHeaderPanel.Controls.Add(label7, 3, 0);
            tableHeaderPanel.Controls.Add(label9, 1, 0);
            tableHeaderPanel.Controls.Add(label10, 0, 0);
            tableHeaderPanel.Dock = DockStyle.Top;
            tableHeaderPanel.Location = new System.Drawing.Point(18, 2);
            tableHeaderPanel.Margin = new Padding(2);
            tableHeaderPanel.Name = "tableHeaderPanel";
            tableHeaderPanel.RowCount = 1;
            tableHeaderPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableHeaderPanel.Size = new System.Drawing.Size(763, 44);
            tableHeaderPanel.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(616, 11);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 26);
            label6.TabIndex = 4;
            label6.Text = "Currency";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(420, 11);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(109, 26);
            label7.TabIndex = 3;
            label7.Text = "Exchange";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(249, 11);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(71, 26);
            label9.TabIndex = 1;
            label9.Text = "Name";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(52, 11);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(86, 26);
            label10.TabIndex = 0;
            label10.Text = "Symbol";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvStocks
            // 
            dgvStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStocks.BackgroundColor = System.Drawing.SystemColors.Menu;
            dgvStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStocks.Dock = DockStyle.Fill;
            dgvStocks.GridColor = System.Drawing.SystemColors.ScrollBar;
            dgvStocks.Location = new System.Drawing.Point(19, 51);
            dgvStocks.Name = "dgvStocks";
            dgvStocks.Size = new System.Drawing.Size(761, 325);
            dgvStocks.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnFilter, 1, 0);
            tableLayoutPanel1.Controls.Add(watchlistLabel, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(42, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(793, 49);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFilter.AutoSize = true;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            btnFilter.FlatAppearance.BorderSize = 2;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnFilter.ForeColor = System.Drawing.Color.Teal;
            btnFilter.Location = new System.Drawing.Point(696, 3);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(94, 34);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "FILTER";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // watchlistLabel
            // 
            watchlistLabel.Anchor = AnchorStyles.Left;
            watchlistLabel.AutoSize = true;
            watchlistLabel.BackColor = System.Drawing.Color.Transparent;
            watchlistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            watchlistLabel.Location = new System.Drawing.Point(3, 9);
            watchlistLabel.Name = "watchlistLabel";
            watchlistLabel.Padding = new Padding(50, 0, 0, 0);
            watchlistLabel.Size = new System.Drawing.Size(184, 31);
            watchlistLabel.TabIndex = 2;
            watchlistLabel.Text = "All Stocks";
            // 
            // allStocksControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel4);
            Margin = new Padding(2);
            Name = "allStocksControl";
            Size = new System.Drawing.Size(894, 514);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableHeaderPanel.ResumeLayout(false);
            tableHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStocks).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableHeaderPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private SimpleScrollBar simpleScrollBar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label watchlistLabel;
        private DataGridView dgvStocks;
        private SimpleScrollBar simpleScrollBar1;
        private Button btnFilter;
    }
}
