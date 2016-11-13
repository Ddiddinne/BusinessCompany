namespace BusinessCompany
{
    partial class ListAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAddEmployee));
            this.annuler = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // annuler
            // 
            this.annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.annuler.Location = new System.Drawing.Point(433, 543);
            this.annuler.Margin = new System.Windows.Forms.Padding(4);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(105, 33);
            this.annuler.TabIndex = 8;
            this.annuler.Text = "Back";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(17, 325);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 17);
            this.label.TabIndex = 7;
            // 
            // list
            // 
            this.list.AutoScroll = true;
            this.list.BackColor = System.Drawing.Color.Transparent;
            this.list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.list.Location = new System.Drawing.Point(196, 80);
            this.list.Margin = new System.Windows.Forms.Padding(4);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(564, 401);
            this.list.TabIndex = 8;
            // 
            // ListAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 662);
            this.ControlBox = false;
            this.Controls.Add(this.list);
            this.Controls.Add(this.label);
            this.Controls.Add(this.annuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel list;
    }
}