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
            this.list = new System.Windows.Forms.Panel();
            this.addProject = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.listEmployees = new System.Windows.Forms.Panel();
            this.CA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.AutoScroll = true;
            this.list.BackColor = System.Drawing.Color.Transparent;
            this.list.Location = new System.Drawing.Point(59, 68);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(290, 100);
            this.list.TabIndex = 6;
            // 
            // addProject
            // 
            this.addProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addProject.Location = new System.Drawing.Point(325, 397);
            this.addProject.Name = "addProject";
            this.addProject.Size = new System.Drawing.Size(79, 27);
            this.addProject.TabIndex = 5;
            this.addProject.Text = "Add";
            this.addProject.UseVisualStyleBackColor = true;
            this.addProject.Click += new System.EventHandler(this.addProject_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.back.Location = new System.Drawing.Point(325, 443);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(79, 27);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // listEmployees
            // 
            this.listEmployees.AutoScroll = true;
            this.listEmployees.BackColor = System.Drawing.Color.Transparent;
            this.listEmployees.Location = new System.Drawing.Point(390, 68);
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(290, 100);
            this.listEmployees.TabIndex = 7;
            // 
            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.BackColor = System.Drawing.Color.Transparent;
            this.CA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.CA.Location = new System.Drawing.Point(13, 13);
            this.CA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(70, 25);
            this.CA.TabIndex = 8;
            this.CA.Text = "label1";
            // 
            // ListProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 538);
            this.Controls.Add(this.CA);
            this.Controls.Add(this.listEmployees);
            this.Controls.Add(this.list);
            this.Controls.Add(this.addProject);
            this.Controls.Add(this.back);
            this.Name = "ListProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListProjects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel list;
        private System.Windows.Forms.Button addProject;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel listEmployees;
        private System.Windows.Forms.Label CA;
    }
}