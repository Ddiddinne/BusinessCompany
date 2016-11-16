namespace BusinessCompany
{
    partial class ListProjects
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.btAddProject = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.pnlListEmployees = new System.Windows.Forms.Panel();
            this.lbCA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.BackColor = System.Drawing.Color.Transparent;
            this.pnlList.Location = new System.Drawing.Point(59, 68);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(334, 100);
            this.pnlList.TabIndex = 6;
            // 
            // btAddProject
            // 
            this.btAddProject.Font = new System.Drawing.Font("Miramonte", 15F);
            this.btAddProject.Location = new System.Drawing.Point(352, 495);
            this.btAddProject.Name = "btAddProject";
            this.btAddProject.Size = new System.Drawing.Size(133, 44);
            this.btAddProject.TabIndex = 5;
            this.btAddProject.Text = "Add Project";
            this.btAddProject.UseVisualStyleBackColor = true;
            this.btAddProject.Click += new System.EventHandler(this.addProject_Click);
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Miramonte", 15F);
            this.btBack.Location = new System.Drawing.Point(369, 545);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(99, 44);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.back_Click);
            // 
            // pnlListEmployees
            // 
            this.pnlListEmployees.AutoScroll = true;
            this.pnlListEmployees.BackColor = System.Drawing.Color.Transparent;
            this.pnlListEmployees.Location = new System.Drawing.Point(466, 68);
            this.pnlListEmployees.Name = "pnlListEmployees";
            this.pnlListEmployees.Size = new System.Drawing.Size(305, 100);
            this.pnlListEmployees.TabIndex = 7;
            // 
            // lbCA
            // 
            this.lbCA.AutoSize = true;
            this.lbCA.BackColor = System.Drawing.Color.Transparent;
            this.lbCA.Font = new System.Drawing.Font("Miramonte", 15F, System.Drawing.FontStyle.Bold);
            this.lbCA.Location = new System.Drawing.Point(13, 13);
            this.lbCA.Margin = new System.Windows.Forms.Padding(4);
            this.lbCA.Name = "lbCA";
            this.lbCA.Size = new System.Drawing.Size(169, 24);
            this.lbCA.TabIndex = 8;
            this.lbCA.Text = "Chiffre d\'affaires";
            // 
            // ListProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 662);
            this.ControlBox = false;
            this.Controls.Add(this.lbCA);
            this.Controls.Add(this.pnlListEmployees);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.btAddProject);
            this.Controls.Add(this.btBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Button btAddProject;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel pnlListEmployees;
        private System.Windows.Forms.Label lbCA;
    }
}