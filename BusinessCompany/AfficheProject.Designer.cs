namespace BusinessCompany
{
    partial class AfficheProject
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
            this.projectName = new System.Windows.Forms.Label();
            this.timeProject = new System.Windows.Forms.Label();
            this.timeConcurent = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(-3, 1);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(285, 54);
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Font = new System.Drawing.Font("Miramonte", 14F);
            this.projectName.Location = new System.Drawing.Point(80, 58);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(119, 24);
            this.projectName.TabIndex = 2;
            this.projectName.Text = "projectName";
            // 
            // timeProject
            // 
            this.timeProject.AutoSize = true;
            this.timeProject.Font = new System.Drawing.Font("Miramonte", 10F);
            this.timeProject.Location = new System.Drawing.Point(224, 95);
            this.timeProject.Name = "timeProject";
            this.timeProject.Size = new System.Drawing.Size(45, 18);
            this.timeProject.TabIndex = 3;
            this.timeProject.Text = "label1";
            // 
            // timeConcurent
            // 
            this.timeConcurent.AutoSize = true;
            this.timeConcurent.Font = new System.Drawing.Font("Miramonte", 10F);
            this.timeConcurent.Location = new System.Drawing.Point(224, 123);
            this.timeConcurent.Name = "timeConcurent";
            this.timeConcurent.Size = new System.Drawing.Size(45, 18);
            this.timeConcurent.TabIndex = 4;
            this.timeConcurent.Text = "label1";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Miramonte", 12F);
            this.add.Location = new System.Drawing.Point(12, 107);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(79, 25);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miramonte", 10F);
            this.label1.Location = new System.Drawing.Point(133, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time to do it:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miramonte", 10F);
            this.label2.Location = new System.Drawing.Point(113, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Your competitor:";
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Miramonte", 12F);
            this.delete.Location = new System.Drawing.Point(12, 107);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(79, 25);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            // 
            // AfficheProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(281, 150);
            this.ControlBox = false;
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.timeConcurent);
            this.Controls.Add(this.timeProject);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AfficheProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AfficheProject";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.Label timeProject;
        private System.Windows.Forms.Label timeConcurent;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
    }
}