namespace BusinessCompany
{
    partial class ModifyLevelCompany
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
            this.lbDefault = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.btApprove = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDefault
            // 
            this.lbDefault.AutoSize = true;
            this.lbDefault.Font = new System.Drawing.Font("Miramonte", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDefault.Location = new System.Drawing.Point(173, 192);
            this.lbDefault.Name = "lbDefault";
            this.lbDefault.Size = new System.Drawing.Size(514, 33);
            this.lbDefault.TabIndex = 0;
            this.lbDefault.Text = "Are you sure you want to change your level?";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Miramonte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(192, 275);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(61, 24);
            this.lbLevel.TabIndex = 1;
            this.lbLevel.Text = "label2";
            // 
            // btApprove
            // 
            this.btApprove.Font = new System.Drawing.Font("Miramonte", 15F);
            this.btApprove.Location = new System.Drawing.Point(313, 395);
            this.btApprove.Name = "btApprove";
            this.btApprove.Size = new System.Drawing.Size(100, 50);
            this.btApprove.TabIndex = 2;
            this.btApprove.Text = "Yes";
            this.btApprove.UseVisualStyleBackColor = true;
            this.btApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Miramonte", 15F);
            this.btCancel.Location = new System.Drawing.Point(442, 395);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 50);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "No";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ModifyLevelCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 662);
            this.ControlBox = false;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btApprove);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbDefault);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifyLevelCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDefault;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Button btApprove;
        private System.Windows.Forms.Button btCancel;
    }
}