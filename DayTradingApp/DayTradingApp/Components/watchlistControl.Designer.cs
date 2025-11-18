namespace DayTradingApp.Components
{
    partial class watchlistControl
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.watchlistLabel = new System.Windows.Forms.Label();
            this.tableHeaderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableContentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.simpleScrollBar = new DayTradingApp.SimpleScrollBar();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableHeaderPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel4.BackgroundImage = global::DayTradingApp.Properties.Resources.square;
            this.tableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.watchlistLabel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(50);
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75862F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.24138F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1149, 686);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // watchlistLabel
            // 
            this.watchlistLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.watchlistLabel.AutoSize = true;
            this.watchlistLabel.BackColor = System.Drawing.Color.Transparent;
            this.watchlistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchlistLabel.Location = new System.Drawing.Point(53, 71);
            this.watchlistLabel.Name = "watchlistLabel";
            this.watchlistLabel.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.watchlistLabel.Size = new System.Drawing.Size(191, 31);
            this.watchlistLabel.TabIndex = 1;
            this.watchlistLabel.Text = "Watch List";
            // 
            // tableHeaderPanel
            // 
            this.tableHeaderPanel.ColumnCount = 5;
            this.tableHeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableHeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableHeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableHeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableHeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableHeaderPanel.Controls.Add(this.label6, 4, 0);
            this.tableHeaderPanel.Controls.Add(this.label7, 3, 0);
            this.tableHeaderPanel.Controls.Add(this.label8, 2, 0);
            this.tableHeaderPanel.Controls.Add(this.label9, 1, 0);
            this.tableHeaderPanel.Controls.Add(this.label10, 0, 0);
            this.tableHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableHeaderPanel.Location = new System.Drawing.Point(23, 3);
            this.tableHeaderPanel.Name = "tableHeaderPanel";
            this.tableHeaderPanel.RowCount = 1;
            this.tableHeaderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableHeaderPanel.Size = new System.Drawing.Size(980, 64);
            this.tableHeaderPanel.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Symbol";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Price";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(642, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Change";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(838, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Volume";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel5.Controls.Add(this.tableHeaderPanel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableContentPanel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.simpleScrollBar, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(53, 127);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 436F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1043, 506);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // tableContentPanel
            // 
            this.tableContentPanel.ColumnCount = 5;
            this.tableContentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableContentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableContentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableContentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableContentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContentPanel.Location = new System.Drawing.Point(23, 73);
            this.tableContentPanel.Name = "tableContentPanel";
            this.tableContentPanel.RowCount = 1;
            this.tableContentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 452F));
            this.tableContentPanel.Size = new System.Drawing.Size(980, 430);
            this.tableContentPanel.TabIndex = 3;
            // 
            // simpleScrollBar
            // 
            this.simpleScrollBar.Location = new System.Drawing.Point(1009, 73);
            this.simpleScrollBar.Maximum = 100;
            this.simpleScrollBar.Name = "simpleScrollBar";
            this.simpleScrollBar.Size = new System.Drawing.Size(11, 430);
            this.simpleScrollBar.TabIndex = 6;
            this.simpleScrollBar.Text = "simpleScrollBar1";
            this.simpleScrollBar.ThumbSize = 120;
            this.simpleScrollBar.Value = 0;
            // 
            // watchlistControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "watchlistControl";
            this.Size = new System.Drawing.Size(1149, 686);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableHeaderPanel.ResumeLayout(false);
            this.tableHeaderPanel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label watchlistLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableHeaderPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableContentPanel;
        private SimpleScrollBar simpleScrollBar;
    }
}
