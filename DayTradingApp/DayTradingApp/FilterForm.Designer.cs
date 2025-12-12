namespace DayTradingApp
{
    partial class FilterForm
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
            panelHeader = new System.Windows.Forms.Panel();
            picClose = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            panelBody = new System.Windows.Forms.Panel();
            btnApply = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtMaxPrice = new System.Windows.Forms.TextBox();
            lblMax = new System.Windows.Forms.Label();
            txtMinPrice = new System.Windows.Forms.TextBox();
            lblMin = new System.Windows.Forms.Label();
            lblPriceRange = new System.Windows.Forms.Label();
            cbSector = new System.Windows.Forms.ComboBox();
            lblSector = new System.Windows.Forms.Label();
            cbCountry = new System.Windows.Forms.ComboBox();
            lblCountry = new System.Windows.Forms.Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.Gainsboro;
            panelHeader.Controls.Add(picClose);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(526, 50);
            panelHeader.TabIndex = 0;
            // 
            // picClose
            // 
            picClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picClose.BackColor = System.Drawing.Color.Transparent;
            picClose.Image = Properties.Resources.close;
            picClose.Location = new System.Drawing.Point(493, 12);
            picClose.Name = "picClose";
            picClose.Size = new System.Drawing.Size(21, 20);
            picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picClose.TabIndex = 1;
            picClose.TabStop = false;
            picClose.Click += picClose_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(213, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(87, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "FILTER";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBody
            // 
            panelBody.BackColor = System.Drawing.Color.White;
            panelBody.Controls.Add(btnApply);
            panelBody.Controls.Add(btnCancel);
            panelBody.Controls.Add(txtMaxPrice);
            panelBody.Controls.Add(lblMax);
            panelBody.Controls.Add(txtMinPrice);
            panelBody.Controls.Add(lblMin);
            panelBody.Controls.Add(lblPriceRange);
            panelBody.Controls.Add(cbSector);
            panelBody.Controls.Add(lblSector);
            panelBody.Controls.Add(cbCountry);
            panelBody.Controls.Add(lblCountry);
            panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            panelBody.Location = new System.Drawing.Point(0, 50);
            panelBody.Name = "panelBody";
            panelBody.Padding = new System.Windows.Forms.Padding(10);
            panelBody.Size = new System.Drawing.Size(526, 420);
            panelBody.TabIndex = 1;
            // 
            // btnApply
            // 
            btnApply.BackgroundImage = Properties.Resources.roundedBtn;
            btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnApply.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnApply.ForeColor = System.Drawing.Color.White;
            btnApply.Location = new System.Drawing.Point(218, 355);
            btnApply.Name = "btnApply";
            btnApply.Size = new System.Drawing.Size(135, 42);
            btnApply.TabIndex = 11;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackgroundImage = Properties.Resources.roundedBtn;
            btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(359, 355);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(135, 42);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new System.Drawing.Point(247, 272);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new System.Drawing.Size(80, 23);
            txtMaxPrice.TabIndex = 9;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMax.Location = new System.Drawing.Point(193, 265);
            lblMax.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            lblMax.Name = "lblMax";
            lblMax.Size = new System.Drawing.Size(41, 17);
            lblMax.TabIndex = 8;
            lblMax.Text = "Max: ";
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new System.Drawing.Point(71, 272);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new System.Drawing.Size(80, 23);
            txtMinPrice.TabIndex = 7;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMin.Location = new System.Drawing.Point(24, 265);
            lblMin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            lblMin.Name = "lblMin";
            lblMin.Size = new System.Drawing.Size(34, 17);
            lblMin.TabIndex = 5;
            lblMin.Text = "Min:";
            // 
            // lblPriceRange
            // 
            lblPriceRange.AutoSize = true;
            lblPriceRange.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPriceRange.Location = new System.Drawing.Point(24, 225);
            lblPriceRange.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            lblPriceRange.Name = "lblPriceRange";
            lblPriceRange.Size = new System.Drawing.Size(117, 25);
            lblPriceRange.TabIndex = 4;
            lblPriceRange.Text = "Price Range";
            // 
            // cbSector
            // 
            cbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbSector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbSector.FormattingEnabled = true;
            cbSector.Items.AddRange(new object[] { "Technology", "Finance", "Healthcare", "Energy", "Utilities", "Consumer" });
            cbSector.Location = new System.Drawing.Point(34, 165);
            cbSector.Name = "cbSector";
            cbSector.Size = new System.Drawing.Size(300, 29);
            cbSector.TabIndex = 3;
            // 
            // lblSector
            // 
            lblSector.AutoSize = true;
            lblSector.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSector.Location = new System.Drawing.Point(24, 122);
            lblSector.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            lblSector.Name = "lblSector";
            lblSector.Size = new System.Drawing.Size(69, 25);
            lblSector.TabIndex = 2;
            lblSector.Text = "Sector";
            // 
            // cbCountry
            // 
            cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbCountry.FormattingEnabled = true;
            cbCountry.Items.AddRange(new object[] { "USA", "Canada", "India", "UK", "Japan" });
            cbCountry.Location = new System.Drawing.Point(34, 67);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new System.Drawing.Size(300, 29);
            cbCountry.TabIndex = 1;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCountry.Location = new System.Drawing.Point(24, 24);
            lblCountry.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new System.Drawing.Size(86, 25);
            lblCountry.TabIndex = 0;
            lblCountry.Text = "Country";
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(526, 470);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Cursor = System.Windows.Forms.Cursors.Hand;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FilterForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Filter";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.ComboBox cbSector;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblPriceRange;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
    }
}