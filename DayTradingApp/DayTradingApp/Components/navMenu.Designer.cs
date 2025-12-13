namespace DayTradingApp.Components
{
    partial class NavMenu
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            homeBtn = new System.Windows.Forms.Button();
            watchlistBtn = new System.Windows.Forms.Button();
            allStocksBtn = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(homeBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(watchlistBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(allStocksBtn, 0, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            tableLayoutPanel1.Size = new System.Drawing.Size(204, 416);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // homeBtn
            // 
            homeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            homeBtn.BackColor = System.Drawing.Color.Transparent;
            homeBtn.BackgroundImage = Properties.Resources.roundedBtntall;
            homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            homeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            homeBtn.ForeColor = System.Drawing.Color.White;
            homeBtn.Location = new System.Drawing.Point(2, 7);
            homeBtn.Margin = new System.Windows.Forms.Padding(2);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new System.Drawing.Size(200, 54);
            homeBtn.TabIndex = 3;
            homeBtn.Tag = "Home";
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Click += navBtn_Click;
            // 
            // watchlistBtn
            // 
            watchlistBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            watchlistBtn.BackColor = System.Drawing.Color.Transparent;
            watchlistBtn.BackgroundImage = Properties.Resources.roundedBtntall_light;
            watchlistBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            watchlistBtn.FlatAppearance.BorderSize = 0;
            watchlistBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            watchlistBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            watchlistBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            watchlistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            watchlistBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            watchlistBtn.ForeColor = System.Drawing.Color.White;
            watchlistBtn.Location = new System.Drawing.Point(2, 76);
            watchlistBtn.Margin = new System.Windows.Forms.Padding(2);
            watchlistBtn.Name = "watchlistBtn";
            watchlistBtn.Size = new System.Drawing.Size(200, 54);
            watchlistBtn.TabIndex = 4;
            watchlistBtn.Tag = "Watchlist";
            watchlistBtn.Text = "Watchlist";
            watchlistBtn.UseVisualStyleBackColor = false;
            watchlistBtn.Click += navBtn_Click;
            // 
            // allStocksBtn
            // 
            allStocksBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            allStocksBtn.BackColor = System.Drawing.Color.Transparent;
            allStocksBtn.BackgroundImage = Properties.Resources.roundedBtntall_light;
            allStocksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            allStocksBtn.FlatAppearance.BorderSize = 0;
            allStocksBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            allStocksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            allStocksBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            allStocksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            allStocksBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            allStocksBtn.ForeColor = System.Drawing.Color.White;
            allStocksBtn.Location = new System.Drawing.Point(2, 145);
            allStocksBtn.Margin = new System.Windows.Forms.Padding(2);
            allStocksBtn.Name = "allStocksBtn";
            allStocksBtn.Size = new System.Drawing.Size(200, 54);
            allStocksBtn.TabIndex = 5;
            allStocksBtn.Tag = "AllStocks";
            allStocksBtn.Text = "All Stocks";
            allStocksBtn.UseVisualStyleBackColor = false;
            allStocksBtn.Click += navBtn_Click;
            // 
            // NavMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "NavMenu";
            Size = new System.Drawing.Size(204, 416);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button watchlistBtn;
        private System.Windows.Forms.Button allStocksBtn;
    }
}
