namespace DayTradingApp.Components
{
    partial class homeControl
    {
        private System.Windows.Forms.TableLayoutPanel stockOverViewTlp;
        private System.Windows.Forms.Label dailyGainLossLbl;

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
        private void InitializeComponent() {
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            stockOverViewTlp = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            dailyPercentLbl = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            dailyGainLossLbl = new System.Windows.Forms.Label();
            symbolLbl = new System.Windows.Forms.Label();
            tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            label14 = new System.Windows.Forms.Label();
            currentPriceLbl = new System.Windows.Forms.Label();
            viewMore_btn = new System.Windows.Forms.Button();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            panel3 = new System.Windows.Forms.Panel();
            tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            tableHeaderPanel = new System.Windows.Forms.TableLayoutPanel();
            label19 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            dgvWatchList = new System.Windows.Forms.DataGridView();
            vScrollBar1 = new System.Windows.Forms.VScrollBar();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            stockOverViewTlp.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWatchList).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(894, 514);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(stockOverViewTlp, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(447, 0);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new System.Drawing.Size(447, 514);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // stockOverViewTlp
            // 
            stockOverViewTlp.BackgroundImage = Properties.Resources.square;
            stockOverViewTlp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            stockOverViewTlp.ColumnCount = 2;
            stockOverViewTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.22449F));
            stockOverViewTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.77551F));
            stockOverViewTlp.Controls.Add(tableLayoutPanel6, 0, 1);
            stockOverViewTlp.Controls.Add(symbolLbl, 0, 0);
            stockOverViewTlp.Controls.Add(tableLayoutPanel8, 0, 2);
            stockOverViewTlp.Controls.Add(viewMore_btn, 1, 2);
            stockOverViewTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            stockOverViewTlp.Location = new System.Drawing.Point(0, 0);
            stockOverViewTlp.Margin = new System.Windows.Forms.Padding(0);
            stockOverViewTlp.Name = "stockOverViewTlp";
            stockOverViewTlp.RowCount = 3;
            stockOverViewTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            stockOverViewTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.4046688F));
            stockOverViewTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.3268471F));
            stockOverViewTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            stockOverViewTlp.Size = new System.Drawing.Size(447, 514);
            stockOverViewTlp.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel6.BackgroundImage = Properties.Resources.roundedBtntall;
            tableLayoutPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.15094F));
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.8490562F));
            tableLayoutPanel6.Controls.Add(dailyPercentLbl, 1, 1);
            tableLayoutPanel6.Controls.Add(label12, 0, 0);
            tableLayoutPanel6.Controls.Add(dailyGainLossLbl, 0, 1);
            tableLayoutPanel6.Location = new System.Drawing.Point(40, 202);
            tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(5, 0, 0, 20);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new System.Drawing.Size(197, 62);
            tableLayoutPanel6.TabIndex = 5;
            // 
            // dailyPercentLbl
            // 
            dailyPercentLbl.AutoSize = true;
            dailyPercentLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dailyPercentLbl.Location = new System.Drawing.Point(129, 31);
            dailyPercentLbl.Name = "dailyPercentLbl";
            dailyPercentLbl.Size = new System.Drawing.Size(59, 19);
            dailyPercentLbl.TabIndex = 5;
            dailyPercentLbl.Text = "+0.00%";
            // 
            // label12
            // 
            label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            label12.Location = new System.Drawing.Point(17, 18);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(106, 13);
            label12.TabIndex = 3;
            label12.Text = "DAILY GAINS/LOSS";
            label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dailyGainLossLbl
            // 
            dailyGainLossLbl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            dailyGainLossLbl.AutoSize = true;
            dailyGainLossLbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            dailyGainLossLbl.Location = new System.Drawing.Point(52, 31);
            dailyGainLossLbl.Name = "dailyGainLossLbl";
            dailyGainLossLbl.Size = new System.Drawing.Size(71, 30);
            dailyGainLossLbl.TabIndex = 4;
            dailyGainLossLbl.Text = "$0.00";
            // 
            // symbolLbl
            // 
            symbolLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            symbolLbl.AutoSize = true;
            symbolLbl.BackColor = System.Drawing.Color.Transparent;
            symbolLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            symbolLbl.Location = new System.Drawing.Point(37, 63);
            symbolLbl.Name = "symbolLbl";
            symbolLbl.Size = new System.Drawing.Size(199, 45);
            symbolLbl.TabIndex = 6;
            symbolLbl.Text = "Stock Name";
            symbolLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanel8.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel8.BackgroundImage = Properties.Resources.roundedBtntall_light;
            tableLayoutPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel8.Controls.Add(label14, 0, 0);
            tableLayoutPanel8.Controls.Add(currentPriceLbl, 0, 1);
            tableLayoutPanel8.Location = new System.Drawing.Point(40, 373);
            tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(5, 0, 0, 20);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new System.Drawing.Size(197, 63);
            tableLayoutPanel8.TabIndex = 8;
            // 
            // label14
            // 
            label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            label14.Location = new System.Drawing.Point(53, 18);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(90, 13);
            label14.TabIndex = 3;
            label14.Text = "CURRENT PRICE";
            label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // currentPriceLbl
            // 
            currentPriceLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            currentPriceLbl.AutoSize = true;
            currentPriceLbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            currentPriceLbl.Location = new System.Drawing.Point(63, 31);
            currentPriceLbl.Name = "currentPriceLbl";
            currentPriceLbl.Size = new System.Drawing.Size(71, 30);
            currentPriceLbl.TabIndex = 4;
            currentPriceLbl.Text = "$0.00";
            // 
            // viewMore_btn
            // 
            viewMore_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            viewMore_btn.BackColor = System.Drawing.Color.Transparent;
            viewMore_btn.BackgroundImage = Properties.Resources.roundedBtntall_DK;
            viewMore_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            viewMore_btn.FlatAppearance.BorderSize = 0;
            viewMore_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            viewMore_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            viewMore_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            viewMore_btn.Location = new System.Drawing.Point(276, 397);
            viewMore_btn.Name = "viewMore_btn";
            viewMore_btn.Size = new System.Drawing.Size(133, 36);
            viewMore_btn.TabIndex = 9;
            viewMore_btn.Text = "VIEW MORE";
            viewMore_btn.UseVisualStyleBackColor = false;
            viewMore_btn.Click += viewMore_btn_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel3, 0, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.0815868F));
            tableLayoutPanel3.Size = new System.Drawing.Size(447, 514);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.square;
            panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel3.Controls.Add(tableLayoutPanel9);
            panel3.Controls.Add(vScrollBar1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Margin = new System.Windows.Forms.Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(447, 514);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            tableLayoutPanel9.Controls.Add(tableHeaderPanel, 0, 0);
            tableLayoutPanel9.Controls.Add(dgvWatchList, 0, 1);
            tableLayoutPanel9.Location = new System.Drawing.Point(8, 122);
            tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 297F));
            tableLayoutPanel9.Size = new System.Drawing.Size(414, 359);
            tableLayoutPanel9.TabIndex = 7;
            // 
            // tableHeaderPanel
            // 
            tableHeaderPanel.ColumnCount = 3;
            tableHeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableHeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableHeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableHeaderPanel.Controls.Add(label19, 0, 0);
            tableHeaderPanel.Controls.Add(label18, 1, 0);
            tableHeaderPanel.Controls.Add(label17, 2, 0);
            tableHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableHeaderPanel.Location = new System.Drawing.Point(18, 2);
            tableHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            tableHeaderPanel.Name = "tableHeaderPanel";
            tableHeaderPanel.RowCount = 1;
            tableHeaderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            tableHeaderPanel.Size = new System.Drawing.Size(370, 58);
            tableHeaderPanel.TabIndex = 5;
            // 
            // label19
            // 
            label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label19.Location = new System.Drawing.Point(26, 16);
            label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(71, 26);
            label19.TabIndex = 1;
            label19.Text = "Name";
            label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label18.Location = new System.Drawing.Point(141, 16);
            label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(86, 26);
            label18.TabIndex = 2;
            label18.Text = "Symbol";
            label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label17.Location = new System.Drawing.Point(258, 16);
            label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(100, 26);
            label17.TabIndex = 3;
            label17.Text = "Currency";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvWatchList
            // 
            dgvWatchList.BackgroundColor = System.Drawing.Color.Silver;
            dgvWatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWatchList.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvWatchList.Location = new System.Drawing.Point(19, 65);
            dgvWatchList.Name = "dgvWatchList";
            dgvWatchList.Size = new System.Drawing.Size(368, 291);
            dgvWatchList.TabIndex = 6;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new System.Drawing.Point(613, 58);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new System.Drawing.Size(17, 622);
            vScrollBar1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(55, 75);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(174, 45);
            label4.TabIndex = 3;
            label4.Text = "Watch List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(55, 58);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(167, 17);
            label3.TabIndex = 2;
            label3.Text = "Watchlist Broad Overview";
            // 
            // homeControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "homeControl";
            Size = new System.Drawing.Size(894, 514);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            stockOverViewTlp.ResumeLayout(false);
            stockOverViewTlp.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableHeaderPanel.ResumeLayout(false);
            tableHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWatchList).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label dailyPercentLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label symbolLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label currentPriceLbl;
        private System.Windows.Forms.Button viewMore_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableHeaderPanel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvWatchList;
    }
}
