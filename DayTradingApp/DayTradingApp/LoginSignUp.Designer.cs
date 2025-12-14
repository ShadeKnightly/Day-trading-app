namespace DayTradingApp {
    partial class LoginSignUp {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            nameInput_Box = new System.Windows.Forms.TextBox();
            emailInput_Box = new System.Windows.Forms.TextBox();
            PassInput_Box = new System.Windows.Forms.TextBox();
            SubmitBtn = new System.Windows.Forms.Button();
            login_signup_toggle = new System.Windows.Forms.Button();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.NestLogo;
            pictureBox1.Location = new System.Drawing.Point(132, 30);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2, 30, 2, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(211, 170);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.BackgroundImage = Properties.Resources.square;
            tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(242, 124);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.74096F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.25904F));
            tableLayoutPanel1.Size = new System.Drawing.Size(475, 452);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(nameInput_Box, 0, 0);
            tableLayoutPanel2.Controls.Add(emailInput_Box, 0, 1);
            tableLayoutPanel2.Controls.Add(PassInput_Box, 0, 2);
            tableLayoutPanel2.Controls.Add(SubmitBtn, 0, 4);
            tableLayoutPanel2.Controls.Add(login_signup_toggle, 0, 3);
            tableLayoutPanel2.Location = new System.Drawing.Point(109, 217);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 45);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new System.Drawing.Size(257, 189);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // nameInput_Box
            // 
            nameInput_Box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            nameInput_Box.BackColor = System.Drawing.Color.White;
            nameInput_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            nameInput_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            nameInput_Box.Location = new System.Drawing.Point(2, 7);
            nameInput_Box.Margin = new System.Windows.Forms.Padding(2);
            nameInput_Box.Name = "nameInput_Box";
            nameInput_Box.Size = new System.Drawing.Size(232, 22);
            nameInput_Box.TabIndex = 2;
            nameInput_Box.Visible = false;
            nameInput_Box.Validating += maskedTxtUserName_Validating;
            // 
            // emailInput_Box
            // 
            emailInput_Box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            emailInput_Box.BackColor = System.Drawing.Color.White;
            emailInput_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            emailInput_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            emailInput_Box.Location = new System.Drawing.Point(2, 44);
            emailInput_Box.Margin = new System.Windows.Forms.Padding(2);
            emailInput_Box.Name = "emailInput_Box";
            emailInput_Box.Size = new System.Drawing.Size(232, 22);
            emailInput_Box.TabIndex = 3;
            emailInput_Box.Validating += txtEmail_Validating;
            // 
            // PassInput_Box
            // 
            PassInput_Box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            PassInput_Box.BackColor = System.Drawing.Color.White;
            PassInput_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PassInput_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            PassInput_Box.Location = new System.Drawing.Point(2, 81);
            PassInput_Box.Margin = new System.Windows.Forms.Padding(2);
            PassInput_Box.Name = "PassInput_Box";
            PassInput_Box.Size = new System.Drawing.Size(232, 22);
            PassInput_Box.TabIndex = 4;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            SubmitBtn.BackgroundImage = Properties.Resources.roundedBtn2;
            SubmitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            SubmitBtn.FlatAppearance.BorderSize = 0;
            SubmitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            SubmitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SubmitBtn.ForeColor = System.Drawing.Color.White;
            SubmitBtn.Location = new System.Drawing.Point(2, 150);
            SubmitBtn.Margin = new System.Windows.Forms.Padding(2);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new System.Drawing.Size(253, 37);
            SubmitBtn.TabIndex = 5;
            SubmitBtn.Text = "SUBMIT";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // login_signup_toggle
            // 
            login_signup_toggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            login_signup_toggle.BackColor = System.Drawing.Color.Transparent;
            login_signup_toggle.BackgroundImage = Properties.Resources.toggleLeft;
            login_signup_toggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            login_signup_toggle.FlatAppearance.BorderSize = 0;
            login_signup_toggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            login_signup_toggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            login_signup_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            login_signup_toggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            login_signup_toggle.ForeColor = System.Drawing.Color.WhiteSmoke;
            login_signup_toggle.Location = new System.Drawing.Point(2, 113);
            login_signup_toggle.Margin = new System.Windows.Forms.Padding(2);
            login_signup_toggle.Name = "login_signup_toggle";
            login_signup_toggle.Size = new System.Drawing.Size(253, 33);
            login_signup_toggle.TabIndex = 0;
            login_signup_toggle.Text = "LOG IN             SIGN UP";
            login_signup_toggle.UseVisualStyleBackColor = false;
            login_signup_toggle.Click += login_signup_toggle_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 1, 1);
            tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(959, 700);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // LoginSignUp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Controls.Add(tableLayoutPanel3);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "LoginSignUp";
            Size = new System.Drawing.Size(959, 700);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox nameInput_Box;
        private System.Windows.Forms.TextBox emailInput_Box;
        private System.Windows.Forms.TextBox PassInput_Box;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button login_signup_toggle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
