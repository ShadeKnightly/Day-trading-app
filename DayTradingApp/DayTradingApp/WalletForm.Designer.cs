namespace DayTradingApp
{
    partial class WalletForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeading = new System.Windows.Forms.Label();
            panelCurrentBalance = new System.Windows.Forms.Panel();
            lblWalletBalance = new System.Windows.Forms.Label();
            lblWalletTitle = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btnRemove = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            lblTransactionAmount = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.PictureBox();
            panelCurrentBalance.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblHeading.AutoSize = true;
            lblHeading.BackColor = System.Drawing.Color.Gainsboro;
            lblHeading.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHeading.Location = new System.Drawing.Point(73, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new System.Drawing.Size(241, 30);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "ADD / REMOVE FUNDS";
            lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelCurrentBalance
            // 
            panelCurrentBalance.AutoSize = true;
            panelCurrentBalance.BackgroundImage = Properties.Resources.square;
            panelCurrentBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panelCurrentBalance.Controls.Add(lblWalletBalance);
            panelCurrentBalance.Controls.Add(lblWalletTitle);
            panelCurrentBalance.Location = new System.Drawing.Point(9, 57);
            panelCurrentBalance.Margin = new System.Windows.Forms.Padding(0);
            panelCurrentBalance.Name = "panelCurrentBalance";
            panelCurrentBalance.Size = new System.Drawing.Size(374, 120);
            panelCurrentBalance.TabIndex = 2;
            // 
            // lblWalletBalance
            // 
            lblWalletBalance.AutoSize = true;
            lblWalletBalance.BackColor = System.Drawing.Color.Transparent;
            lblWalletBalance.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblWalletBalance.Location = new System.Drawing.Point(45, 49);
            lblWalletBalance.Name = "lblWalletBalance";
            lblWalletBalance.Size = new System.Drawing.Size(155, 37);
            lblWalletBalance.TabIndex = 1;
            lblWalletBalance.Text = "$5.00 CAD";
            // 
            // lblWalletTitle
            // 
            lblWalletTitle.AutoSize = true;
            lblWalletTitle.BackColor = System.Drawing.Color.Transparent;
            lblWalletTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblWalletTitle.Location = new System.Drawing.Point(45, 19);
            lblWalletTitle.Name = "lblWalletTitle";
            lblWalletTitle.Size = new System.Drawing.Size(59, 21);
            lblWalletTitle.TabIndex = 0;
            lblWalletTitle.Text = "Wallet";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.square;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(lblTransactionAmount);
            panel1.Location = new System.Drawing.Point(9, 177);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(374, 199);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnRemove, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(34, 99);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(300, 56);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = System.Drawing.Color.Transparent;
            btnRemove.BackgroundImage = Properties.Resources.roundedBtn;
            btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRemove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRemove.ForeColor = System.Drawing.Color.White;
            btnRemove.Location = new System.Drawing.Point(153, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(144, 50);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.Transparent;
            btnAdd.BackgroundImage = Properties.Resources.roundedBtn;
            btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(144, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // lblTransactionAmount
            // 
            lblTransactionAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblTransactionAmount.AutoSize = true;
            lblTransactionAmount.BackColor = System.Drawing.Color.Transparent;
            lblTransactionAmount.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTransactionAmount.Location = new System.Drawing.Point(37, 28);
            lblTransactionAmount.Name = "lblTransactionAmount";
            lblTransactionAmount.Size = new System.Drawing.Size(211, 50);
            lblTransactionAmount.TabIndex = 1;
            lblTransactionAmount.Text = "$0.00 CAD";
            lblTransactionAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClose.BackColor = System.Drawing.Color.Transparent;
            btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new System.Drawing.Point(359, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(15, 15);
            btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // WalletForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(392, 381);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            Controls.Add(panelCurrentBalance);
            Controls.Add(lblHeading);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "WalletForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "WalletForm";
            panelCurrentBalance.ResumeLayout(false);
            panelCurrentBalance.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panelCurrentBalance;
        private System.Windows.Forms.Label lblWalletBalance;
        private System.Windows.Forms.Label lblWalletTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTransactionAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox btnClose;
    }
}