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
            this.companyName = new System.Windows.Forms.Label();
            this.employees = new System.Windows.Forms.Button();
            this.projects = new System.Windows.Forms.Button();
            this.bourse = new System.Windows.Forms.Button();
            this.CA = new System.Windows.Forms.Label();
            this.btnModifyLivel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.BackColor = System.Drawing.Color.Transparent;
            this.companyName.Font = new System.Drawing.Font("Miramonte", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.companyName.Location = new System.Drawing.Point(248, 42);
            this.companyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(201, 33);
            this.companyName.TabIndex = 1;
            this.companyName.Text = "companyName";
            // 
            // employees
            // 
            this.employees.BackColor = System.Drawing.Color.Transparent;
            this.employees.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.employees.FlatAppearance.BorderSize = 0;
            this.employees.Location = new System.Drawing.Point(254, 172);
            this.employees.Margin = new System.Windows.Forms.Padding(0);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(184, 42);
            this.employees.TabIndex = 3;
            this.employees.Text = "Employees";
            this.employees.UseVisualStyleBackColor = false;
            this.employees.Click += new System.EventHandler(this.employees_Click);
            // 
            // projects
            // 
            this.projects.Location = new System.Drawing.Point(254, 240);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(184, 42);
            this.projects.TabIndex = 4;
            this.projects.Text = "Projects";
            this.projects.UseVisualStyleBackColor = true;
            // 
            // bourse
            // 
            this.bourse.Location = new System.Drawing.Point(254, 315);
            this.bourse.Name = "bourse";
            this.bourse.Size = new System.Drawing.Size(184, 42);
            this.bourse.TabIndex = 5;
            this.bourse.Text = "Bourse";
            this.bourse.UseVisualStyleBackColor = true;
            // 
            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.BackColor = System.Drawing.Color.Transparent;
            this.CA.Font = new System.Drawing.Font("Miramonte", 15F, System.Drawing.FontStyle.Bold);
            this.CA.Location = new System.Drawing.Point(33, 24);
            this.CA.Margin = new System.Windows.Forms.Padding(4);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(68, 24);
            this.CA.TabIndex = 2;
            this.CA.Text = "label1";
            // 
            // btnModifyLivel
            // 
            this.btnModifyLivel.Location = new System.Drawing.Point(254, 411);
            this.btnModifyLivel.Name = "btnModifyLivel";
            this.btnModifyLivel.Size = new System.Drawing.Size(184, 35);
            this.btnModifyLivel.TabIndex = 6;
            this.btnModifyLivel.Text = "Upgrade Company";
            this.btnModifyLivel.UseVisualStyleBackColor = true;
            this.btnModifyLivel.Click += new System.EventHandler(this.btnModifyLivel_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BusinessCompany.Properties.Resources.room_b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 538);
            this.Controls.Add(this.btnModifyLivel);
            this.Controls.Add(this.bourse);
            this.Controls.Add(this.projects);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.CA);
            this.Controls.Add(this.companyName);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Button projects;
        private System.Windows.Forms.Button bourse;

        private System.Windows.Forms.Label CA;
        private System.Windows.Forms.Button btnModifyLivel;
    }
}

