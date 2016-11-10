namespace BusinessCompany
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
            this.list = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // annuler
            // 
            this.annuler.Font = new System.Drawing.Font("Miramonte", 10F);
            this.annuler.Location = new System.Drawing.Point(322, 453);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(79, 27);
            this.annuler.TabIndex = 8;
            this.annuler.Text = "Back";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click_1);
            // 
            // list
            // 
            this.list.AutoScroll = true;
            this.list.BackColor = System.Drawing.Color.Transparent;
            this.list.Location = new System.Drawing.Point(162, 55);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(379, 356);
            this.list.TabIndex = 9;
            // 
            // ListAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 538);
            this.Controls.Add(this.list);
            this.Controls.Add(this.annuler);
            this.Name = "ListAddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListAddProject";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Panel list;
    }
}