namespace BusinessCompany
{
    partial class AfficheEmployee
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.addEmployee = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(2, 4);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(52, 86);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(135, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 1;
            this.name.Text = "name";
            // 
            // addEmployee
            // 
            this.addEmployee.Location = new System.Drawing.Point(110, 67);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(75, 23);
            this.addEmployee.TabIndex = 2;
            this.addEmployee.Text = "Add Employee";
            this.addEmployee.UseVisualStyleBackColor = true;
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.ForeColor = System.Drawing.Color.Black;
            this.salary.Location = new System.Drawing.Point(223, 22);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(34, 13);
            this.salary.TabIndex = 3;
            this.salary.Text = "salary";
            // 
            // AfficheEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(281, 94);
            this.ControlBox = false;
            this.Controls.Add(this.salary);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.name);
            this.Controls.Add(this.picture);
            this.Enabled = false;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AfficheEmployee";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Label salary;
    }
}