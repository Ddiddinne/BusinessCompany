﻿namespace BusinessCompany
{
    partial class ListEmployees
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
            this.back = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.panelEmployees = new System.Windows.Forms.Panel();
            this.panelFormations = new System.Windows.Forms.Panel();
            this.CA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Miramonte", 10F);
            this.back.Location = new System.Drawing.Point(327, 457);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(79, 27);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // addEmployee
            // 
            this.addEmployee.Font = new System.Drawing.Font("Miramonte", 10F);
            this.addEmployee.Location = new System.Drawing.Point(327, 409);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(79, 27);
            this.addEmployee.TabIndex = 2;
            this.addEmployee.Text = "Add Employee";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // panelEmployees
            // 
            this.panelEmployees.AutoScroll = true;
            this.panelEmployees.BackColor = System.Drawing.Color.Transparent;
            this.panelEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEmployees.Location = new System.Drawing.Point(44, 57);
            this.panelEmployees.Name = "panelEmployees";
            this.panelEmployees.Size = new System.Drawing.Size(301, 100);
            this.panelEmployees.TabIndex = 3;
            // 
            // panelFormations
            // 
            this.panelFormations.AutoScroll = true;
            this.panelFormations.BackColor = System.Drawing.Color.Transparent;
            this.panelFormations.Location = new System.Drawing.Point(373, 57);
            this.panelFormations.Name = "panelFormations";
            this.panelFormations.Size = new System.Drawing.Size(301, 100);
            this.panelFormations.TabIndex = 4;
            this.panelFormations.Visible = false;
            // 
            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.BackColor = System.Drawing.Color.Transparent;
            this.CA.Font = new System.Drawing.Font("Miramonte", 15F, System.Drawing.FontStyle.Bold);
            this.CA.Location = new System.Drawing.Point(13, 13);
            this.CA.Margin = new System.Windows.Forms.Padding(4);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(68, 24);
            this.CA.TabIndex = 3;
            this.CA.Text = "label1";
            // 
            // ListEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 538);
            this.Controls.Add(this.CA);
            this.Controls.Add(this.panelFormations);
            this.Controls.Add(this.panelEmployees);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.back);
            this.Name = "ListEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListEmploye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Panel panelEmployees;
        private System.Windows.Forms.Panel panelFormations;
        private System.Windows.Forms.Label CA;
    }
}