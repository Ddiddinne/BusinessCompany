namespace BusinessCompany
{
    partial class AfficheFormation
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
            this.nameFormation = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbXpEarn = new System.Windows.Forms.Label();
            this.btForm = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // nameFormation
            // 
            this.nameFormation.AutoSize = true;
            this.nameFormation.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFormation.Location = new System.Drawing.Point(102, 9);
            this.nameFormation.Name = "nameFormation";
            this.nameFormation.Size = new System.Drawing.Size(143, 19);
            this.nameFormation.TabIndex = 1;
            this.nameFormation.Text = "lbNameFormation";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Miramonte", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(106, 38);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(49, 18);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "lbPrice";
            // 
            // lbXpEarn
            // 
            this.lbXpEarn.AutoSize = true;
            this.lbXpEarn.Font = new System.Drawing.Font("Miramonte", 10F);
            this.lbXpEarn.Location = new System.Drawing.Point(203, 38);
            this.lbXpEarn.Name = "lbXpEarn";
            this.lbXpEarn.Size = new System.Drawing.Size(64, 18);
            this.lbXpEarn.TabIndex = 3;
            this.lbXpEarn.Text = "lbXpEarn";
            // 
            // btForm
            // 
            this.btForm.Font = new System.Drawing.Font("Miramonte", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btForm.Location = new System.Drawing.Point(140, 63);
            this.btForm.Name = "btForm";
            this.btForm.Size = new System.Drawing.Size(75, 23);
            this.btForm.TabIndex = 4;
            this.btForm.Text = "Form";
            this.btForm.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.Image = global::BusinessCompany.Properties.Resources.formation;
            this.logo.Location = new System.Drawing.Point(13, 13);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(65, 69);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // AfficheFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(281, 94);
            this.Controls.Add(this.btForm);
            this.Controls.Add(this.lbXpEarn);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.nameFormation);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AfficheFormation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AfficheFormation";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label nameFormation;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbXpEarn;
        private System.Windows.Forms.Button btForm;
    }
}