﻿namespace Drawing
{
    partial class DrawingLines
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
            this.SuspendLayout();
            // 
            // DrawingLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 443);
            this.Name = "DrawingLines";
            this.Text = "Drawing Lines";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingLines_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingLines_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}