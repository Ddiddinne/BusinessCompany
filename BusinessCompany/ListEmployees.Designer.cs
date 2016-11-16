namespace BusinessCompany
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
            this.btBack = new System.Windows.Forms.Button();
            this.btAddEmployee = new System.Windows.Forms.Button();
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.pnlFormations = new System.Windows.Forms.Panel();
            this.lbCA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Miramonte", 15F);
            this.btBack.Location = new System.Drawing.Point(379, 541);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(99, 44);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.back_Click);
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.Font = new System.Drawing.Font("Miramonte", 15F);
            this.btAddEmployee.Location = new System.Drawing.Point(342, 491);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(174, 44);
            this.btAddEmployee.TabIndex = 2;
            this.btAddEmployee.Text = "Add Employee";
            this.btAddEmployee.UseVisualStyleBackColor = true;
            this.btAddEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.AutoScroll = true;
            this.pnlEmployees.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEmployees.Location = new System.Drawing.Point(85, 57);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(331, 100);
            this.pnlEmployees.TabIndex = 3;
            // 
            // pnlFormations
            // 
            this.pnlFormations.AutoScroll = true;
            this.pnlFormations.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormations.Location = new System.Drawing.Point(472, 57);
            this.pnlFormations.Name = "pnlFormations";
            this.pnlFormations.Size = new System.Drawing.Size(301, 100);
            this.pnlFormations.TabIndex = 4;
            this.pnlFormations.Visible = false;
            // 
            // lbCA
            // 
            this.lbCA.AutoSize = true;
            this.lbCA.BackColor = System.Drawing.Color.Transparent;
            this.lbCA.Font = new System.Drawing.Font("Miramonte", 15F, System.Drawing.FontStyle.Bold);
            this.lbCA.Location = new System.Drawing.Point(13, 13);
            this.lbCA.Margin = new System.Windows.Forms.Padding(4);
            this.lbCA.Name = "lbCA";
            this.lbCA.Size = new System.Drawing.Size(68, 24);
            this.lbCA.TabIndex = 3;
            this.lbCA.Text = "label1";
            // 
            // ListEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 662);
            this.ControlBox = false;
            this.Controls.Add(this.lbCA);
            this.Controls.Add(this.pnlFormations);
            this.Controls.Add(this.pnlEmployees);
            this.Controls.Add(this.btAddEmployee);
            this.Controls.Add(this.btBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btAddEmployee;
        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.Panel pnlFormations;
        private System.Windows.Forms.Label lbCA;
    }
}