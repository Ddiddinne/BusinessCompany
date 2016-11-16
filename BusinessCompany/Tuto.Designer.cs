namespace BusinessCompany
{
    partial class Tuto
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
            this.btOk = new System.Windows.Forms.Button();
            this.lbStory = new System.Windows.Forms.Label();
            this.btSkipTuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(520, 492);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(108, 36);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.ok_Click);
            // 
            // lbStory
            // 
            this.lbStory.BackColor = System.Drawing.Color.Transparent;
            this.lbStory.Font = new System.Drawing.Font("Miramonte", 15F);
            this.lbStory.Location = new System.Drawing.Point(434, 128);
            this.lbStory.Name = "lbStory";
            this.lbStory.Size = new System.Drawing.Size(297, 310);
            this.lbStory.TabIndex = 2;
            this.lbStory.Text = "Story";
            this.lbStory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSkipTuto
            // 
            this.btSkipTuto.Font = new System.Drawing.Font("Miramonte", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSkipTuto.Location = new System.Drawing.Point(535, 460);
            this.btSkipTuto.Name = "btSkipTuto";
            this.btSkipTuto.Size = new System.Drawing.Size(82, 26);
            this.btSkipTuto.TabIndex = 4;
            this.btSkipTuto.Text = "Skip Tuto";
            this.btSkipTuto.UseVisualStyleBackColor = true;
            this.btSkipTuto.Click += new System.EventHandler(this.skipTuto_Click);
            // 
            // Tuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BusinessCompany.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 662);
            this.ControlBox = false;
            this.Controls.Add(this.btSkipTuto);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lbStory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Company";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label lbStory;
        private System.Windows.Forms.Button btSkipTuto;
    }
}