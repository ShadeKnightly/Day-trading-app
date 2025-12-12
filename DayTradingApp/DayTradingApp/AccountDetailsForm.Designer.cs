namespace DayTradingApp
{
    partial class AccountDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            { components.Dispose(); }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDetailsForm));
            panelHeader = new System.Windows.Forms.Panel();
            btnClose = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            panelBody = new System.Windows.Forms.Panel();
            btnSave = new System.Windows.Forms.Button();
            chkShowPassword = new System.Windows.Forms.CheckBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            btnEdit = new System.Windows.Forms.Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.LightGray;
            panelHeader.Controls.Add(btnClose);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(468, 55);
            panelHeader.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new System.Drawing.Point(432, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(15, 15);
            btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 14F);
            lblTitle.Location = new System.Drawing.Point(120, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(189, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ACCOUNT DETAILS";
            // 
            // panelBody
            // 
            panelBody.BackColor = System.Drawing.Color.White;
            panelBody.Controls.Add(btnEdit);
            panelBody.Controls.Add(btnSave);
            panelBody.Controls.Add(chkShowPassword);
            panelBody.Controls.Add(txtPassword);
            panelBody.Controls.Add(txtEmail);
            panelBody.Controls.Add(txtName);
            panelBody.Controls.Add(lblPassword);
            panelBody.Controls.Add(lblEmail);
            panelBody.Controls.Add(lblName);
            panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            panelBody.Location = new System.Drawing.Point(0, 55);
            panelBody.Name = "panelBody";
            panelBody.Size = new System.Drawing.Size(468, 319);
            panelBody.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Transparent;
            btnSave.BackgroundImage = Properties.Resources.roundedBtn;
            btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(295, 246);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(115, 32);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Location = new System.Drawing.Point(150, 195);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new System.Drawing.Size(104, 24);
            chkShowPassword.TabIndex = 1;
            chkShowPassword.Text = "Show";
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(150, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(260, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(150, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(260, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(150, 40);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(260, 23);
            txtName.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblPassword.Location = new System.Drawing.Point(30, 160);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(100, 23);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblEmail.Location = new System.Drawing.Point(30, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(100, 23);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblName.Location = new System.Drawing.Point(30, 40);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(100, 23);
            lblName.TabIndex = 7;
            lblName.Text = "Name";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = System.Drawing.Color.Transparent;
            btnEdit.BackgroundImage = Properties.Resources.roundedBtn;
            btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEdit.ForeColor = System.Drawing.Color.White;
            btnEdit.Location = new System.Drawing.Point(174, 246);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(115, 32);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // AccountDetailsForm
            // 
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(468, 374);
            ControlBox = false;
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "AccountDetailsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnEdit;
    }
}
