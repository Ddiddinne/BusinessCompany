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
            this.btBack = new System.Windows.Forms.Button();
            this.pnList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Miramonte", 15F);
            this.btBack.Location = new System.Drawing.Point(374, 554);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(99, 44);
            this.btBack.TabIndex = 8;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.annuler_Click_1);
            // 
            // pnList
            // 
            this.pnList.AutoScroll = true;
            this.pnList.BackColor = System.Drawing.Color.Transparent;
            this.pnList.Location = new System.Drawing.Point(213, 93);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(290, 100);
            this.pnList.TabIndex = 9;
            // 
            // ListAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 662);
            this.ControlBox = false;
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.btBack);
            this.Font = new System.Drawing.Font("Miramonte", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListAddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Company";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel pnList;
    }
}