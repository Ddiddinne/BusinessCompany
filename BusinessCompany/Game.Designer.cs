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
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.btEmployees = new System.Windows.Forms.Button();
            this.btProjects = new System.Windows.Forms.Button();
            this.lbCA = new System.Windows.Forms.Label();
            this.btModifyLevel = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.BackColor = System.Drawing.Color.White;
            this.lbCompanyName.Font = new System.Drawing.Font("Miramonte", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCompanyName.Location = new System.Drawing.Point(346, 123);
            this.lbCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(201, 33);
            this.lbCompanyName.TabIndex = 1;
            this.lbCompanyName.Text = "companyName";
            // 
            // btEmployees
            // 
            this.btEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btEmployees.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btEmployees.FlatAppearance.BorderSize = 0;
            this.btEmployees.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployees.Location = new System.Drawing.Point(352, 269);
            this.btEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.btEmployees.Name = "btEmployees";
            this.btEmployees.Size = new System.Drawing.Size(184, 42);
            this.btEmployees.TabIndex = 3;
            this.btEmployees.Text = "Employees";
            this.btEmployees.UseVisualStyleBackColor = false;
            this.btEmployees.Click += new System.EventHandler(this.employees_Click);
            // 
            // btProjects
            // 
            this.btProjects.Font = new System.Drawing.Font("Miramonte", 12F);
            this.btProjects.Location = new System.Drawing.Point(352, 340);
            this.btProjects.Name = "btProjects";
            this.btProjects.Size = new System.Drawing.Size(184, 42);
            this.btProjects.TabIndex = 4;
            this.btProjects.Text = "Projects";
            this.btProjects.UseVisualStyleBackColor = true;
            this.btProjects.Click += new System.EventHandler(this.projects_Click);
            // 
            // lbCA
            // 
            this.lbCA.AutoSize = true;
            this.lbCA.BackColor = System.Drawing.Color.Transparent;
            this.lbCA.Font = new System.Drawing.Font("Miramonte", 15F, System.Drawing.FontStyle.Bold);
            this.lbCA.Location = new System.Drawing.Point(33, 24);
            this.lbCA.Margin = new System.Windows.Forms.Padding(4);
            this.lbCA.Name = "lbCA";
            this.lbCA.Size = new System.Drawing.Size(171, 24);
            this.lbCA.TabIndex = 2;
            this.lbCA.Text = "Chiffre d\'Affaires";
            // 
            // btModifyLevel
            // 
            this.btModifyLevel.Font = new System.Drawing.Font("Miramonte", 12F);
            this.btModifyLevel.Location = new System.Drawing.Point(328, 462);
            this.btModifyLevel.Name = "btModifyLevel";
            this.btModifyLevel.Size = new System.Drawing.Size(219, 42);
            this.btModifyLevel.TabIndex = 6;
            this.btModifyLevel.Text = "Upgrade Company";
            this.btModifyLevel.UseVisualStyleBackColor = true;
            this.btModifyLevel.Click += new System.EventHandler(this.btnModifyLevel_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Miramonte", 15F, System.Drawing.FontStyle.Bold);
            this.lbDate.Location = new System.Drawing.Point(683, 24);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(55, 24);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "Date";
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Miramonte", 12F);
            this.btExit.Location = new System.Drawing.Point(352, 510);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(184, 42);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 662);
            this.ControlBox = false;
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btModifyLevel);
            this.Controls.Add(this.btProjects);
            this.Controls.Add(this.btEmployees);
            this.Controls.Add(this.lbCA);
            this.Controls.Add(this.lbCompanyName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Button btEmployees;
        private System.Windows.Forms.Button btProjects;

        private System.Windows.Forms.Label lbCA;
        private System.Windows.Forms.Button btModifyLevel;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btExit;
    }
}

