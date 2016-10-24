namespace BusinessCompany
{
    partial class Game
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
            this.CA = new System.Windows.Forms.TextBox();
            this.companyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CA
            // 
            this.CA.Location = new System.Drawing.Point(13, 13);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(100, 20);
            this.CA.TabIndex = 0;
            this.CA.Text = "3000";
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Location = new System.Drawing.Point(389, 63);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(35, 13);
            this.companyName.TabIndex = 1;
            this.companyName.Text = "label1";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 443);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.CA);
            this.Name = "Game";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CA;
        private System.Windows.Forms.Label companyName;
    }
}

