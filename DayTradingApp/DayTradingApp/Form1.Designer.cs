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
            this.mainFormDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // mainFormDisplay
            // 
            this.mainFormDisplay.ColumnCount = 1;
            this.mainFormDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainFormDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormDisplay.Location = new System.Drawing.Point(0, 0);
            this.mainFormDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainFormDisplay.Name = "mainFormDisplay";
            this.mainFormDisplay.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.mainFormDisplay.RowCount = 1;
            this.mainFormDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainFormDisplay.Size = new System.Drawing.Size(1341, 765);
            this.mainFormDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1341, 765);
            this.Controls.Add(this.mainFormDisplay);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nest Trading App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TableLayoutPanel mainFormDisplay;
    }
}

