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
            this.add = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.Label();
            this.specialisation = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.assigned = new System.Windows.Forms.CheckBox();
            this.xp = new System.Windows.Forms.Label();
            this.btFormations = new System.Windows.Forms.Button();
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
            // add
            // 
            this.add.Location = new System.Drawing.Point(110, 67);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.addEmployee_Click);
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
            // specialisation
            // 
            this.specialisation.AutoSize = true;
            this.specialisation.Location = new System.Drawing.Point(73, 33);
            this.specialisation.Name = "specialisation";
            this.specialisation.Size = new System.Drawing.Size(70, 13);
            this.specialisation.TabIndex = 4;
            this.specialisation.Text = "specialisation";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.BackColor = System.Drawing.SystemColors.Window;
            this.level.ForeColor = System.Drawing.Color.Black;
            this.level.Location = new System.Drawing.Point(60, 9);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(29, 13);
            this.level.TabIndex = 5;
            this.level.Text = "level";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(191, 67);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // assigned
            // 
            this.assigned.AutoSize = true;
            this.assigned.ForeColor = System.Drawing.Color.Black;
            this.assigned.Location = new System.Drawing.Point(176, 67);
            this.assigned.Name = "assigned";
            this.assigned.Size = new System.Drawing.Size(69, 17);
            this.assigned.TabIndex = 7;
            this.assigned.Text = "Assigned";
            this.assigned.UseVisualStyleBackColor = true;
            this.assigned.Visible = false;
            // 
            // xp
            // 
            this.xp.AutoSize = true;
            this.xp.ForeColor = System.Drawing.Color.Black;
            this.xp.Location = new System.Drawing.Point(222, 40);
            this.xp.Name = "xp";
            this.xp.Size = new System.Drawing.Size(18, 13);
            this.xp.TabIndex = 8;
            this.xp.Text = "xp";
            // 
            // btFormations
            // 
            this.btFormations.Font = new System.Drawing.Font("Miramonte", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFormations.ForeColor = System.Drawing.Color.Black;
            this.btFormations.Location = new System.Drawing.Point(76, 63);
            this.btFormations.Name = "btFormations";
            this.btFormations.Size = new System.Drawing.Size(92, 23);
            this.btFormations.TabIndex = 9;
            this.btFormations.Text = "Formations";
            this.btFormations.UseVisualStyleBackColor = true;
            this.btFormations.Visible = false;
            // 
            // AfficheEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(281, 94);
            this.ControlBox = false;
            this.Controls.Add(this.btFormations);
            this.Controls.Add(this.xp);
            this.Controls.Add(this.assigned);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.level);
            this.Controls.Add(this.specialisation);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.add);
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
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label specialisation;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.CheckBox assigned;
        private System.Windows.Forms.Label xp;
        private System.Windows.Forms.Button btFormations;
    }
}