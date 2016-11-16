namespace BusinessCompany
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.inpNameCompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btValid = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.levelchecked = new System.Windows.Forms.GroupBox();
            this.rdBtLevel3 = new System.Windows.Forms.RadioButton();
            this.rdBtLevel2 = new System.Windows.Forms.RadioButton();
            this.rdBtLevel1 = new System.Windows.Forms.RadioButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.levelchecked.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // inpNameCompany
            // 
            this.inpNameCompany.Font = new System.Drawing.Font("Miramonte", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpNameCompany.Location = new System.Drawing.Point(512, 275);
            this.inpNameCompany.Name = "inpNameCompany";
            this.inpNameCompany.Size = new System.Drawing.Size(100, 29);
            this.inpNameCompany.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miramonte", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name of the Compagny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miramonte", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "level";
            // 
            // btValid
            // 
            this.btValid.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValid.Location = new System.Drawing.Point(432, 492);
            this.btValid.Name = "btValid";
            this.btValid.Size = new System.Drawing.Size(113, 56);
            this.btValid.TabIndex = 10;
            this.btValid.Text = "Validate";
            this.btValid.UseVisualStyleBackColor = true;
            this.btValid.Click += new System.EventHandler(this.valid_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(586, 492);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(113, 56);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // levelchecked
            // 
            this.levelchecked.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.levelchecked.Controls.Add(this.rdBtLevel3);
            this.levelchecked.Controls.Add(this.rdBtLevel2);
            this.levelchecked.Controls.Add(this.rdBtLevel1);
            this.levelchecked.Location = new System.Drawing.Point(432, 371);
            this.levelchecked.Name = "levelchecked";
            this.levelchecked.Size = new System.Drawing.Size(267, 65);
            this.levelchecked.TabIndex = 13;
            this.levelchecked.TabStop = false;
            // 
            // rdBtLevel3
            // 
            this.rdBtLevel3.AutoSize = true;
            this.rdBtLevel3.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtLevel3.Location = new System.Drawing.Point(198, 19);
            this.rdBtLevel3.Name = "rdBtLevel3";
            this.rdBtLevel3.Size = new System.Drawing.Size(59, 23);
            this.rdBtLevel3.TabIndex = 6;
            this.rdBtLevel3.TabStop = true;
            this.rdBtLevel3.Text = "hard";
            this.rdBtLevel3.UseVisualStyleBackColor = true;
            // 
            // rdBtLevel2
            // 
            this.rdBtLevel2.AutoSize = true;
            this.rdBtLevel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdBtLevel2.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtLevel2.Location = new System.Drawing.Point(78, 19);
            this.rdBtLevel2.Name = "rdBtLevel2";
            this.rdBtLevel2.Size = new System.Drawing.Size(114, 23);
            this.rdBtLevel2.TabIndex = 5;
            this.rdBtLevel2.TabStop = true;
            this.rdBtLevel2.Text = "intermediate";
            this.rdBtLevel2.UseVisualStyleBackColor = false;
            // 
            // rdBtLevel1
            // 
            this.rdBtLevel1.AutoSize = true;
            this.rdBtLevel1.Checked = true;
            this.rdBtLevel1.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtLevel1.Location = new System.Drawing.Point(15, 19);
            this.rdBtLevel1.Name = "rdBtLevel1";
            this.rdBtLevel1.Size = new System.Drawing.Size(57, 23);
            this.rdBtLevel1.TabIndex = 4;
            this.rdBtLevel1.TabStop = true;
            this.rdBtLevel1.Text = "easy";
            this.rdBtLevel1.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Miramonte", 22F, System.Drawing.FontStyle.Bold);
            this.lbTitle.Location = new System.Drawing.Point(356, 42);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(441, 137);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "Let\'s go to create our Start up!!";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::BusinessCompany.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 662);
            this.ControlBox = false;
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.levelchecked);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btValid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inpNameCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Company";
            this.levelchecked.ResumeLayout(false);
            this.levelchecked.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox inpNameCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btValid;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.GroupBox levelchecked;
        private System.Windows.Forms.RadioButton rdBtLevel3;
        private System.Windows.Forms.RadioButton rdBtLevel2;
        private System.Windows.Forms.RadioButton rdBtLevel1;
        private System.Windows.Forms.Label lbTitle;
    }
}