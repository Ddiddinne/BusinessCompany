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
            this.back = new System.Windows.Forms.Button();
            this.addAmployee = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(283, 442);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // addAmployee
            // 
            this.addAmployee.Location = new System.Drawing.Point(283, 396);
            this.addAmployee.Name = "addAmployee";
            this.addAmployee.Size = new System.Drawing.Size(75, 23);
            this.addAmployee.TabIndex = 2;
            this.addAmployee.Text = "Add Employee";
            this.addAmployee.UseVisualStyleBackColor = true;
            // 
            // list
            // 
            this.list.AutoScroll = true;
            this.list.Location = new System.Drawing.Point(133, 71);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(379, 100);
            this.list.TabIndex = 3;
            // 
            // ListEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 566);
            this.Controls.Add(this.list);
            this.Controls.Add(this.addAmployee);
            this.Controls.Add(this.back);
            this.Name = "ListEmployees";
            this.Text = "ListEmploye";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button addAmployee;
        private System.Windows.Forms.Panel list;
    }
}