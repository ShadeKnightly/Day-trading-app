namespace DayTradingApp.Components
{
    partial class profileControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profileControl));
            profileIcon = new System.Windows.Forms.TableLayoutPanel();
            nameLabel = new System.Windows.Forms.Label();
            pbHamburger = new System.Windows.Forms.PictureBox();
            pbAccount = new System.Windows.Forms.PictureBox();
            profileIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAccount).BeginInit();
            SuspendLayout();
            // 
            // profileIcon
            // 
            profileIcon.BackgroundImage = Properties.Resources.roundedTextBox;
            profileIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            profileIcon.ColumnCount = 3;
            profileIcon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.58824F));
            profileIcon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.41177F));
            profileIcon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.70588F));
            profileIcon.Controls.Add(nameLabel, 1, 0);
            profileIcon.Controls.Add(pbHamburger, 0, 0);
            profileIcon.Controls.Add(pbAccount, 2, 0);
            profileIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            profileIcon.Location = new System.Drawing.Point(0, 0);
            profileIcon.Margin = new System.Windows.Forms.Padding(2);
            profileIcon.Name = "profileIcon";
            profileIcon.RowCount = 1;
            profileIcon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            profileIcon.Size = new System.Drawing.Size(251, 58);
            profileIcon.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nameLabel.Location = new System.Drawing.Point(100, 19);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(51, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // pbHamburger
            // 
            pbHamburger.Anchor = System.Windows.Forms.AnchorStyles.Right;
            pbHamburger.BackColor = System.Drawing.Color.Transparent;
            pbHamburger.Cursor = System.Windows.Forms.Cursors.Hand;
            pbHamburger.ErrorImage = null;
            pbHamburger.Image = (System.Drawing.Image)resources.GetObject("pbHamburger.Image");
            pbHamburger.InitialImage = null;
            pbHamburger.Location = new System.Drawing.Point(31, 18);
            pbHamburger.Margin = new System.Windows.Forms.Padding(2);
            pbHamburger.Name = "pbHamburger";
            pbHamburger.Size = new System.Drawing.Size(31, 22);
            pbHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbHamburger.TabIndex = 2;
            pbHamburger.TabStop = false;
            // 
            // pbAccount
            // 
            pbAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pbAccount.BackColor = System.Drawing.Color.Transparent;
            pbAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            pbAccount.Image = (System.Drawing.Image)resources.GetObject("pbAccount.Image");
            pbAccount.Location = new System.Drawing.Point(190, 14);
            pbAccount.Margin = new System.Windows.Forms.Padding(2);
            pbAccount.Name = "pbAccount";
            pbAccount.Size = new System.Drawing.Size(20, 29);
            pbAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbAccount.TabIndex = 3;
            pbAccount.TabStop = false;
            pbAccount.Click += pbAccount_Click;
            // 
            // profileControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(profileIcon);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "profileControl";
            Size = new System.Drawing.Size(251, 58);
            profileIcon.ResumeLayout(false);
            profileIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAccount).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel profileIcon;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pbHamburger;
        private System.Windows.Forms.PictureBox pbAccount;
    }
}
