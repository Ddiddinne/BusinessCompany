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
            this.lbName = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.btFire = new System.Windows.Forms.Button();
            this.chkAssigned = new System.Windows.Forms.CheckBox();
            this.lbXp = new System.Windows.Forms.Label();
            this.btForm = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(135, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 19);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "name";
            // 
            // btAdd
            // 
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Location = new System.Drawing.Point(110, 67);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Miramonte", 10F);
            this.lbSalary.ForeColor = System.Drawing.Color.Black;
            this.lbSalary.Location = new System.Drawing.Point(198, 33);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(43, 18);
            this.lbSalary.TabIndex = 3;
            this.lbSalary.Text = "salary";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.BackColor = System.Drawing.SystemColors.Window;
            this.lbLevel.Font = new System.Drawing.Font("Miramonte", 10F);
            this.lbLevel.ForeColor = System.Drawing.Color.Black;
            this.lbLevel.Location = new System.Drawing.Point(60, 9);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(34, 18);
            this.lbLevel.TabIndex = 5;
            this.lbLevel.Text = "level";
            // 
            // btFire
            // 
            this.btFire.Font = new System.Drawing.Font("Miramonte", 10F);
            this.btFire.ForeColor = System.Drawing.Color.Black;
            this.btFire.Location = new System.Drawing.Point(191, 67);
            this.btFire.Name = "btFire";
            this.btFire.Size = new System.Drawing.Size(75, 23);
            this.btFire.TabIndex = 6;
            this.btFire.Text = "Fire";
            this.btFire.UseVisualStyleBackColor = true;
            // 
            // chkAssigned
            // 
            this.chkAssigned.AutoSize = true;
            this.chkAssigned.Font = new System.Drawing.Font("Miramonte", 10F);
            this.chkAssigned.ForeColor = System.Drawing.Color.Black;
            this.chkAssigned.Location = new System.Drawing.Point(139, 67);
            this.chkAssigned.Name = "chkAssigned";
            this.chkAssigned.Size = new System.Drawing.Size(80, 22);
            this.chkAssigned.TabIndex = 7;
            this.chkAssigned.Text = "Assigned";
            this.chkAssigned.UseVisualStyleBackColor = true;
            this.chkAssigned.Visible = false;
            // 
            // lbXp
            // 
            this.lbXp.AutoSize = true;
            this.lbXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXp.ForeColor = System.Drawing.Color.Black;
            this.lbXp.Location = new System.Drawing.Point(107, 33);
            this.lbXp.Name = "lbXp";
            this.lbXp.Size = new System.Drawing.Size(22, 17);
            this.lbXp.TabIndex = 8;
            this.lbXp.Text = "xp";
            // 
            // btForm
            // 
            this.btForm.Font = new System.Drawing.Font("Miramonte", 10F);
            this.btForm.ForeColor = System.Drawing.Color.Black;
            this.btForm.Location = new System.Drawing.Point(76, 67);
            this.btForm.Name = "btForm";
            this.btForm.Size = new System.Drawing.Size(92, 23);
            this.btForm.TabIndex = 9;
            this.btForm.Text = "Formations";
            this.btForm.UseVisualStyleBackColor = true;
            this.btForm.Visible = false;
            // 
            // picture
            // 
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.Location = new System.Drawing.Point(2, 4);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(52, 86);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // AfficheEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(281, 94);
            this.ControlBox = false;
            this.Controls.Add(this.btForm);
            this.Controls.Add(this.lbXp);
            this.Controls.Add(this.chkAssigned);
            this.Controls.Add(this.btFire);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.picture);
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
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Button btFire;
        private System.Windows.Forms.CheckBox chkAssigned;
        private System.Windows.Forms.Label lbXp;
        private System.Windows.Forms.Button btForm;
    }
}