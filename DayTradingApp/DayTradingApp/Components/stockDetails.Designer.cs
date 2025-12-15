namespace DayTradingApp.Components
{
    partial class stockDetails
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
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            btn5years = new System.Windows.Forms.Button();
            btn1year = new System.Windows.Forms.Button();
            btn3months = new System.Windows.Forms.Button();
            btn1month = new System.Windows.Forms.Button();
            btn1week = new System.Windows.Forms.Button();
            btn1day = new System.Windows.Forms.Button();
            stockDetailsLabel = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            watchlist_toggle = new System.Windows.Forms.Button();
            watchlist_toggle_lbl = new System.Windows.Forms.Label();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            curValLbl = new System.Windows.Forms.Label();
            value = new System.Windows.Forms.Button();
            currency = new System.Windows.Forms.Button();
            stockGraph1 = new StockGraph();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel4.BackgroundImage = Properties.Resources.square;
            tableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel4.Controls.Add(stockDetailsLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel1, 0, 4);
            tableLayoutPanel4.Controls.Add(stockGraph1, 0, 1);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(60, 39, 60, 39);
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5458164F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.4541855F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            tableLayoutPanel4.Size = new System.Drawing.Size(894, 514);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel2.BackgroundImage = Properties.Resources.long_rnd;
            tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Controls.Add(btn5years, 5, 0);
            tableLayoutPanel2.Controls.Add(btn1year, 4, 0);
            tableLayoutPanel2.Controls.Add(btn3months, 3, 0);
            tableLayoutPanel2.Controls.Add(btn1month, 2, 0);
            tableLayoutPanel2.Controls.Add(btn1week, 1, 0);
            tableLayoutPanel2.Controls.Add(btn1day, 0, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(63, 344);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(45, 0, 45, 0);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(768, 39);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btn5years
            // 
            btn5years.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            btn5years.BackColor = System.Drawing.Color.Transparent;
            btn5years.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn5years.FlatAppearance.BorderSize = 0;
            btn5years.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn5years.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btn5years.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btn5years.Location = new System.Drawing.Point(610, 0);
            btn5years.Margin = new System.Windows.Forms.Padding(0);
            btn5years.Name = "btn5years";
            btn5years.Size = new System.Drawing.Size(113, 39);
            btn5years.TabIndex = 5;
            btn5years.Text = "5 Years";
            btn5years.UseVisualStyleBackColor = false;
            // 
            // btn1year
            // 
            btn1year.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            btn1year.BackColor = System.Drawing.Color.Transparent;
            btn1year.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn1year.FlatAppearance.BorderSize = 0;
            btn1year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn1year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btn1year.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btn1year.Location = new System.Drawing.Point(497, 0);
            btn1year.Margin = new System.Windows.Forms.Padding(0);
            btn1year.Name = "btn1year";
            btn1year.Size = new System.Drawing.Size(113, 39);
            btn1year.TabIndex = 4;
            btn1year.Text = "1 Year";
            btn1year.UseVisualStyleBackColor = false;
            // 
            // btn3months
            // 
            btn3months.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            btn3months.BackColor = System.Drawing.Color.Transparent;
            btn3months.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn3months.FlatAppearance.BorderSize = 0;
            btn3months.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn3months.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btn3months.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btn3months.Location = new System.Drawing.Point(384, 0);
            btn3months.Margin = new System.Windows.Forms.Padding(0);
            btn3months.Name = "btn3months";
            btn3months.Size = new System.Drawing.Size(113, 39);
            btn3months.TabIndex = 3;
            btn3months.Text = "3 Months";
            btn3months.UseVisualStyleBackColor = false;
            // 
            // btn1month
            // 
            btn1month.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            btn1month.BackColor = System.Drawing.Color.Transparent;
            btn1month.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn1month.FlatAppearance.BorderSize = 0;
            btn1month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn1month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btn1month.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btn1month.Location = new System.Drawing.Point(271, 0);
            btn1month.Margin = new System.Windows.Forms.Padding(0);
            btn1month.Name = "btn1month";
            btn1month.Size = new System.Drawing.Size(113, 39);
            btn1month.TabIndex = 2;
            btn1month.Text = "1 Month";
            btn1month.UseVisualStyleBackColor = false;
            // 
            // btn1week
            // 
            btn1week.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            btn1week.BackColor = System.Drawing.Color.Transparent;
            btn1week.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn1week.FlatAppearance.BorderSize = 0;
            btn1week.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn1week.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btn1week.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btn1week.Location = new System.Drawing.Point(158, 0);
            btn1week.Margin = new System.Windows.Forms.Padding(0);
            btn1week.Name = "btn1week";
            btn1week.Size = new System.Drawing.Size(113, 39);
            btn1week.TabIndex = 1;
            btn1week.Text = "1 Week";
            btn1week.UseVisualStyleBackColor = false;
            // 
            // btn1day
            // 
            btn1day.Anchor = System.Windows.Forms.AnchorStyles.Top;
            btn1day.BackColor = System.Drawing.Color.Transparent;
            btn1day.BackgroundImage = Properties.Resources.roundedBtntall;
            btn1day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn1day.FlatAppearance.BorderSize = 0;
            btn1day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn1day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btn1day.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btn1day.Location = new System.Drawing.Point(45, 0);
            btn1day.Margin = new System.Windows.Forms.Padding(0);
            btn1day.Name = "btn1day";
            btn1day.Size = new System.Drawing.Size(113, 39);
            btn1day.TabIndex = 0;
            btn1day.Text = "1 Day";
            btn1day.UseVisualStyleBackColor = false;
            // 
            // stockDetailsLabel
            // 
            stockDetailsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            stockDetailsLabel.AutoSize = true;
            stockDetailsLabel.BackColor = System.Drawing.Color.Transparent;
            stockDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            stockDetailsLabel.Location = new System.Drawing.Point(63, 44);
            stockDetailsLabel.Name = "stockDetailsLabel";
            stockDetailsLabel.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            stockDetailsLabel.Size = new System.Drawing.Size(212, 31);
            stockDetailsLabel.TabIndex = 2;
            stockDetailsLabel.Text = "Stock Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.55814F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.44186F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            tableLayoutPanel1.Controls.Add(watchlist_toggle, 2, 0);
            tableLayoutPanel1.Controls.Add(watchlist_toggle_lbl, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(63, 418);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(768, 54);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // watchlist_toggle
            // 
            watchlist_toggle.BackColor = System.Drawing.Color.Transparent;
            watchlist_toggle.BackgroundImage = Properties.Resources.addbtn;
            watchlist_toggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            watchlist_toggle.FlatAppearance.BorderSize = 0;
            watchlist_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            watchlist_toggle.Location = new System.Drawing.Point(691, 3);
            watchlist_toggle.Name = "watchlist_toggle";
            watchlist_toggle.Size = new System.Drawing.Size(74, 48);
            watchlist_toggle.TabIndex = 0;
            watchlist_toggle.UseVisualStyleBackColor = false;
            watchlist_toggle.Click += watchlist_toggle_Click;
            // 
            // watchlist_toggle_lbl
            // 
            watchlist_toggle_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            watchlist_toggle_lbl.AutoSize = true;
            watchlist_toggle_lbl.BackColor = System.Drawing.Color.Transparent;
            watchlist_toggle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            watchlist_toggle_lbl.Location = new System.Drawing.Point(510, 17);
            watchlist_toggle_lbl.Name = "watchlist_toggle_lbl";
            watchlist_toggle_lbl.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            watchlist_toggle_lbl.Size = new System.Drawing.Size(175, 20);
            watchlist_toggle_lbl.TabIndex = 3;
            watchlist_toggle_lbl.Text = "Add to Watchlist";
            watchlist_toggle_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackgroundImage = Properties.Resources.long_rnd;
            tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.73684F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.3684216F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.6470585F));
            tableLayoutPanel3.Controls.Add(curValLbl, 0, 0);
            tableLayoutPanel3.Controls.Add(currency, 2, 0);
            tableLayoutPanel3.Controls.Add(value, 1, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new System.Drawing.Size(390, 48);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // curValLbl
            // 
            curValLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            curValLbl.AutoSize = true;
            curValLbl.BackColor = System.Drawing.Color.Transparent;
            curValLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            curValLbl.Location = new System.Drawing.Point(8, 14);
            curValLbl.Name = "curValLbl";
            curValLbl.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            curValLbl.Size = new System.Drawing.Size(170, 20);
            curValLbl.TabIndex = 5;
            curValLbl.Text = "Current Value";
            // 
            // value
            // 
            value.Anchor = System.Windows.Forms.AnchorStyles.Right;
            value.BackColor = System.Drawing.Color.Transparent;
            value.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            value.FlatAppearance.BorderSize = 0;
            value.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            value.ForeColor = System.Drawing.Color.Black;
            value.Location = new System.Drawing.Point(256, 5);
            value.Margin = new System.Windows.Forms.Padding(0);
            value.Name = "value";
            value.Size = new System.Drawing.Size(61, 38);
            value.TabIndex = 4;
            value.Text = "$0.00";
            value.UseVisualStyleBackColor = false;
            // 
            // currency
            // 
            currency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            currency.BackColor = System.Drawing.Color.Transparent;
            currency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            currency.FlatAppearance.BorderSize = 0;
            currency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            currency.ForeColor = System.Drawing.Color.Black;
            currency.Location = new System.Drawing.Point(317, 5);
            currency.Margin = new System.Windows.Forms.Padding(0);
            currency.Name = "currency";
            currency.Size = new System.Drawing.Size(55, 38);
            currency.TabIndex = 3;
            currency.Text = "CAD";
            currency.UseVisualStyleBackColor = false;
            // 
            // stockGraph1
            // 
            stockGraph1.Dock = System.Windows.Forms.DockStyle.Fill;
            stockGraph1.Location = new System.Drawing.Point(63, 83);
            stockGraph1.Name = "stockGraph1";
            stockGraph1.Size = new System.Drawing.Size(768, 255);
            stockGraph1.TabIndex = 5;
            // 
            // stockDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel4);
            Name = "stockDetails";
            Size = new System.Drawing.Size(894, 514);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label stockDetailsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn1day;
        private System.Windows.Forms.Button btn5years;
        private System.Windows.Forms.Button btn1year;
        private System.Windows.Forms.Button btn3months;
        private System.Windows.Forms.Button btn1month;
        private System.Windows.Forms.Button btn1week;
        private System.Windows.Forms.Button watchlist_toggle;
        private System.Windows.Forms.Label watchlist_toggle_lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button currency;
        private System.Windows.Forms.Button value;
        private System.Windows.Forms.Label curValLbl;
        private StockGraph stockGraph1;
    }
}
