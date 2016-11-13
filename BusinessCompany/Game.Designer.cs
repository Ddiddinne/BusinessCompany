﻿namespace BusinessCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.companyName = new System.Windows.Forms.Label();
            this.employees = new System.Windows.Forms.Button();
            this.projects = new System.Windows.Forms.Button();
            this.CA = new System.Windows.Forms.Label();
            this.btnModifyLivel = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.gameLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyName
            // 
            this.companyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.companyName.AutoSize = true;
            this.companyName.BackColor = System.Drawing.Color.Transparent;
            this.companyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.companyName.Location = new System.Drawing.Point(247, 17);
            this.companyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(257, 39);
            this.companyName.TabIndex = 1;
            this.companyName.Text = "companyName";
            // 
            // employees
            // 
            this.employees.BackColor = System.Drawing.Color.Transparent;
            this.employees.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.employees.FlatAppearance.BorderSize = 0;
            this.employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employees.Location = new System.Drawing.Point(254, 188);
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
            this.projects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.projects.Location = new System.Drawing.Point(254, 259);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(184, 42);
            this.projects.TabIndex = 4;
            this.projects.Text = "Projects";
            this.projects.UseVisualStyleBackColor = true;
            this.projects.Click += new System.EventHandler(this.projects_Click);
            // 
            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.BackColor = System.Drawing.Color.Transparent;
            this.CA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.CA.Location = new System.Drawing.Point(33, 24);
            this.CA.Margin = new System.Windows.Forms.Padding(4);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(87, 29);
            this.CA.TabIndex = 2;
            this.CA.Text = "label1";
            // 
            // btnModifyLivel
            // 
            this.btnModifyLivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModifyLivel.Location = new System.Drawing.Point(254, 411);
            this.btnModifyLivel.Name = "btnModifyLivel";
            this.btnModifyLivel.Size = new System.Drawing.Size(184, 42);
            this.btnModifyLivel.TabIndex = 6;
            this.btnModifyLivel.Text = "Upgrade Company";
            this.btnModifyLivel.UseVisualStyleBackColor = true;
            this.btnModifyLivel.Click += new System.EventHandler(this.btnModifyLevel_Click);
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbDate.Location = new System.Drawing.Point(716, 27);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(70, 29);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "Date";
            // 
            // gameLeave
            // 
            this.gameLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLeave.Location = new System.Drawing.Point(255, 508);
            this.gameLeave.Name = "gameLeave";
            this.gameLeave.Size = new System.Drawing.Size(184, 42);
            this.gameLeave.TabIndex = 8;
            this.gameLeave.Text = "Leave Game";
            this.gameLeave.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BusinessCompany.Properties.Resources.room_b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 662);
            this.ControlBox = false;
            this.Controls.Add(this.gameLeave);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btnModifyLivel);
            this.Controls.Add(this.projects);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.CA);
            this.Controls.Add(this.companyName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Button projects;

        private System.Windows.Forms.Label CA;
        private System.Windows.Forms.Button btnModifyLivel;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button gameLeave;
    }
}

