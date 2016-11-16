namespace BusinessCompany
{
    partial class ListAddEmployee
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
            this.label = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Miramonte", 15F);
            this.btBack.Location = new System.Drawing.Point(375, 554);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(99, 44);
            this.btBack.TabIndex = 8;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.annuler_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 264);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 7;
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.BackColor = System.Drawing.Color.Transparent;
            this.pnlList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlList.Location = new System.Drawing.Point(147, 65);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(584, 423);
            this.pnlList.TabIndex = 8;
            // 
            // ListAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 662);
            this.ControlBox = false;
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel pnlList;
    }
}