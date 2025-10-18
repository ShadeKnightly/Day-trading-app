using System;

namespace DayTradingApp
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.signupLink = new System.Windows.Forms.Label();
            this.nameInput_Box = new System.Windows.Forms.TextBox();
            this.emailInput_Box = new System.Windows.Forms.TextBox();
            this.PassInput_Box = new System.Windows.Forms.TextBox();
            this.login_signup_toggle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 682);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.login_signup_toggle, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.signupLink, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.nameInput_Box, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.emailInput_Box, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PassInput_Box, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 344);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(667, 335);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // signupLink
            // 
            this.signupLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupLink.AutoSize = true;
            this.signupLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLink.ForeColor = System.Drawing.Color.Teal;
            this.signupLink.Location = new System.Drawing.Point(147, 307);
            this.signupLink.Name = "signupLink";
            this.signupLink.Size = new System.Drawing.Size(372, 20);
            this.signupLink.TabIndex = 1;
            this.signupLink.Text = "Don\'t have an account? Click here to sign up!";
            this.signupLink.Click += new System.EventHandler(this.signUpLink_Click);
            // 
            // nameInput_Box
            // 
            this.nameInput_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameInput_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameInput_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput_Box.Location = new System.Drawing.Point(164, 18);
            this.nameInput_Box.Name = "nameInput_Box";
            this.nameInput_Box.Size = new System.Drawing.Size(339, 32);
            this.nameInput_Box.TabIndex = 2;
            this.nameInput_Box.Text = " Name";
            this.nameInput_Box.Visible = false;
            // 
            // emailInput_Box
            // 
            this.emailInput_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailInput_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailInput_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailInput_Box.Location = new System.Drawing.Point(164, 93);
            this.emailInput_Box.Name = "emailInput_Box";
            this.emailInput_Box.Size = new System.Drawing.Size(339, 32);
            this.emailInput_Box.TabIndex = 3;
            this.emailInput_Box.Text = " Email";
            // 
            // PassInput_Box
            // 
            this.PassInput_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassInput_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassInput_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassInput_Box.Location = new System.Drawing.Point(164, 168);
            this.PassInput_Box.Name = "PassInput_Box";
            this.PassInput_Box.Size = new System.Drawing.Size(339, 32);
            this.PassInput_Box.TabIndex = 4;
            this.PassInput_Box.Text = " Password";
            // 
            // login_signup_toggle
            // 
            this.login_signup_toggle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_signup_toggle.AutoSize = true;
            this.login_signup_toggle.BackColor = System.Drawing.Color.Transparent;
            this.login_signup_toggle.BackgroundImage = global::DayTradingApp.Properties.Resources.toggleLeft;
            this.login_signup_toggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login_signup_toggle.FlatAppearance.BorderSize = 0;
            this.login_signup_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_signup_toggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_signup_toggle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.login_signup_toggle.Location = new System.Drawing.Point(49, 233);
            this.login_signup_toggle.Name = "login_signup_toggle";
            this.login_signup_toggle.Size = new System.Drawing.Size(568, 59);
            this.login_signup_toggle.TabIndex = 0;
            this.login_signup_toggle.Text = "       LOG IN             SIGN UP";
            this.login_signup_toggle.UseVisualStyleBackColor = false;
            this.login_signup_toggle.Click += new System.EventHandler(this.login_signup_toggle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DayTradingApp.Properties.Resources.NestLogo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.login_signup_toggle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DayTradingApp.Properties.Resources.square;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(733, 794);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

     

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login_signup_toggle;
        private System.Windows.Forms.Label signupLink;
        private System.Windows.Forms.TextBox nameInput_Box;
        private System.Windows.Forms.TextBox emailInput_Box;
        private System.Windows.Forms.TextBox PassInput_Box;
    }
}

