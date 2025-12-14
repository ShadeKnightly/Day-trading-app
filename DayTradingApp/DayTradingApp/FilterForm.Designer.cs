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
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnApply = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            name = new System.Windows.Forms.TextBox();
            Symbol = new System.Windows.Forms.TextBox();
            lblPriceRange = new System.Windows.Forms.Label();
            Currency = new System.Windows.Forms.ComboBox();
            lblSector = new System.Windows.Forms.Label();
            Exchange = new System.Windows.Forms.ComboBox();
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
            panelHeader.Size = new System.Drawing.Size(383, 50);
            panelHeader.TabIndex = 0;
            // 
            // picClose
            // 
            picClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picClose.BackColor = System.Drawing.Color.Transparent;
            picClose.Image = Properties.Resources.close;
            picClose.Location = new System.Drawing.Point(350, 12);
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
            lblTitle.Location = new System.Drawing.Point(145, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(87, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "FILTER";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBody
            // 
            panelBody.BackColor = System.Drawing.Color.White;
            panelBody.Controls.Add(label2);
            panelBody.Controls.Add(label1);
            panelBody.Controls.Add(btnApply);
            panelBody.Controls.Add(btnCancel);
            panelBody.Controls.Add(name);
            panelBody.Controls.Add(Symbol);
            panelBody.Controls.Add(lblPriceRange);
            panelBody.Controls.Add(Currency);
            panelBody.Controls.Add(lblSector);
            panelBody.Controls.Add(Exchange);
            panelBody.Controls.Add(lblCountry);
            panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            panelBody.Location = new System.Drawing.Point(0, 50);
            panelBody.Name = "panelBody";
            panelBody.Padding = new System.Windows.Forms.Padding(10);
            panelBody.Size = new System.Drawing.Size(383, 261);
            panelBody.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(24, 32);
            label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 25);
            label2.TabIndex = 13;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(24, 120);
            label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 25);
            label1.TabIndex = 12;
            label1.Text = "Symbol";
            // 
            // btnApply
            // 
            btnApply.BackgroundImage = Properties.Resources.roundedBtn;
            btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnApply.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnApply.ForeColor = System.Drawing.Color.White;
            btnApply.Location = new System.Drawing.Point(85, 208);
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
            btnCancel.Location = new System.Drawing.Point(235, 208);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(135, 42);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // name
            // 
            name.Location = new System.Drawing.Point(24, 65);
            name.Name = "name";
            name.Size = new System.Drawing.Size(219, 23);
            name.TabIndex = 9;
            // 
            // Symbol
            // 
            Symbol.Location = new System.Drawing.Point(24, 153);
            Symbol.Name = "Symbol";
            Symbol.Size = new System.Drawing.Size(79, 23);
            Symbol.TabIndex = 7;
            // 
            // lblPriceRange
            // 
            lblPriceRange.AutoSize = true;
            lblPriceRange.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPriceRange.Location = new System.Drawing.Point(24, 225);
            lblPriceRange.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            lblPriceRange.Name = "lblPriceRange";
            lblPriceRange.Size = new System.Drawing.Size(0, 25);
            lblPriceRange.TabIndex = 4;
            // 
            // Currency
            // 
            Currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Currency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Currency.FormattingEnabled = true;
            Currency.Items.AddRange(new object[] { "USD", "CAD", "EUR", "CHF", "SEK" });
            Currency.Location = new System.Drawing.Point(253, 153);
            Currency.Name = "Currency";
            Currency.Size = new System.Drawing.Size(97, 29);
            Currency.TabIndex = 3;
            // 
            // lblSector
            // 
            lblSector.AutoSize = true;
            lblSector.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSector.Location = new System.Drawing.Point(253, 120);
            lblSector.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            lblSector.Name = "lblSector";
            lblSector.Size = new System.Drawing.Size(93, 25);
            lblSector.TabIndex = 2;
            lblSector.Text = "Currency";
            // 
            // Exchange
            // 
            Exchange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Exchange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Exchange.FormattingEnabled = true;
            Exchange.Items.AddRange(new object[] { "US", "LSE", "NEO", "V", "TO" });
            Exchange.Location = new System.Drawing.Point(135, 153);
            Exchange.Name = "Exchange";
            Exchange.Size = new System.Drawing.Size(97, 29);
            Exchange.TabIndex = 1;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCountry.Location = new System.Drawing.Point(135, 120);
            lblCountry.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new System.Drawing.Size(97, 25);
            lblCountry.TabIndex = 0;
            lblCountry.Text = "Exchange";
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(383, 311);
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
        private System.Windows.Forms.ComboBox Currency;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.ComboBox Exchange;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblPriceRange;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox Symbol;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}