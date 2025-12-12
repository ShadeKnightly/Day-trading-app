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
            if (disposing)
            {
                _marketReport?.Dispose();
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
            mainFormDisplay = new System.Windows.Forms.TableLayoutPanel();
            SuspendLayout();
            // 
            // mainFormDisplay
            // 
            mainFormDisplay.ColumnCount = 1;
            mainFormDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            mainFormDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            mainFormDisplay.Location = new System.Drawing.Point(0, 0);
            mainFormDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mainFormDisplay.Name = "mainFormDisplay";
            mainFormDisplay.RowCount = 1;
            mainFormDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            mainFormDisplay.Size = new System.Drawing.Size(959, 700);
            mainFormDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(959, 700);
            Controls.Add(mainFormDisplay);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Nest Trading App";
            Load += Form1_Load;
            ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TableLayoutPanel mainFormDisplay;
    }
}

