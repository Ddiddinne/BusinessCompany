﻿namespace BusinessCompany
{
    partial class AfficheStory
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
            this.lbStory = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStory
            // 
            this.lbStory.BackColor = System.Drawing.Color.Transparent;
            this.lbStory.Font = new System.Drawing.Font("Miramonte", 15F);
            this.lbStory.Location = new System.Drawing.Point(351, 53);
            this.lbStory.Name = "lbStory";
            this.lbStory.Size = new System.Drawing.Size(297, 310);
            this.lbStory.TabIndex = 0;
            this.lbStory.Text = "Story";
            this.lbStory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Miramonte", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(457, 382);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(82, 26);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // AfficheStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BusinessCompany.Properties.Resources.backgroudStory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 538);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.lbStory);
            this.Name = "AfficheStory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfficheStory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbStory;
        private System.Windows.Forms.Button ok;
    }
}