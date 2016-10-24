namespace BusinessCompany
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
            this.companyName = new System.Windows.Forms.Label();

            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CA
            // 
            this.CA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.CA.Location = new System.Drawing.Point(17, 16);
            this.CA.Margin = new System.Windows.Forms.Padding(4);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(132, 22);
            this.CA.TabIndex = 0;
            this.CA.Text = "3000";
            // 

            
            
            // 

            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Location = new System.Drawing.Point(42, 55);
            this.companyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(46, 17);
            this.companyName.TabIndex = 1;
            this.companyName.Text = "label1";
            // 

            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BusinessCompany.Properties.Resources.room_b;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(366, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 156);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(445, 180);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Employees";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(445, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;

            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.Location = new System.Drawing.Point(30, 22);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(35, 13);
            this.CA.TabIndex = 2;
            this.CA.Text = "label1";

            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackgroundImage = global::BusinessCompany.Properties.Resources.building;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 545);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.CA);
            this.Margin = new System.Windows.Forms.Padding(4);

            this.ClientSize = new System.Drawing.Size(837, 443);
            this.Controls.Add(this.CA);
            this.Controls.Add(this.companyName);

            this.Name = "Game";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label companyName;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label CA;

    }
}

