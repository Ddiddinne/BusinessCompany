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
            this.valider = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(223, 255);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 23);
            this.valider.TabIndex = 5;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(223, 307);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 6;
            this.annuler.Text = "Back";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 264);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 7;
            // 
            // ListAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 399);
            this.Controls.Add(this.label);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.valider);
            this.Name = "ListAddEmployee";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Label label;
    }
}