﻿namespace BusinessCompany
{
    partial class ListAddProject
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
            this.annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(322, 453);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 8;
            this.annuler.Text = "Back";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click_1);
            // 
            // ListAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 538);
            this.Controls.Add(this.annuler);
            this.Name = "ListAddProject";
            this.Text = "ListAddProject";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button annuler;
    }
}