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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.watchlistBtn = new System.Windows.Forms.Button();
            this.allStocksBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.homeBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.watchlistBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.allStocksBtn, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 555);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BackgroundImage = global::DayTradingApp.Properties.Resources.roundedBtn2;
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Location = new System.Drawing.Point(31, 21);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(200, 50);
            this.homeBtn.TabIndex = 3;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.navBtn_Click);
            // 
            // watchlistBtn
            // 
            this.watchlistBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.watchlistBtn.BackColor = System.Drawing.Color.Transparent;
            this.watchlistBtn.BackgroundImage = global::DayTradingApp.Properties.Resources.roundedBtn2;
            this.watchlistBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.watchlistBtn.FlatAppearance.BorderSize = 0;
            this.watchlistBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.watchlistBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.watchlistBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.watchlistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchlistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchlistBtn.Location = new System.Drawing.Point(31, 113);
            this.watchlistBtn.Name = "watchlistBtn";
            this.watchlistBtn.Size = new System.Drawing.Size(200, 50);
            this.watchlistBtn.TabIndex = 4;
            this.watchlistBtn.Text = "Watchlist";
            this.watchlistBtn.UseVisualStyleBackColor = false;
            this.watchlistBtn.Click += new System.EventHandler(this.navBtn_Click);
            // 
            // allStocksBtn
            // 
            this.allStocksBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allStocksBtn.BackColor = System.Drawing.Color.Transparent;
            this.allStocksBtn.BackgroundImage = global::DayTradingApp.Properties.Resources.roundedBtn2;
            this.allStocksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allStocksBtn.FlatAppearance.BorderSize = 0;
            this.allStocksBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.allStocksBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.allStocksBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.allStocksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allStocksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allStocksBtn.Location = new System.Drawing.Point(31, 205);
            this.allStocksBtn.Name = "allStocksBtn";
            this.allStocksBtn.Size = new System.Drawing.Size(200, 50);
            this.allStocksBtn.TabIndex = 5;
            this.allStocksBtn.Text = "All Stocks";
            this.allStocksBtn.UseVisualStyleBackColor = false;
            this.allStocksBtn.Click += new System.EventHandler(this.navBtn_Click);
            // 
            // NavMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NavMenu";
            this.Size = new System.Drawing.Size(262, 555);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button watchlistBtn;
        private System.Windows.Forms.Button allStocksBtn;
    }
}
