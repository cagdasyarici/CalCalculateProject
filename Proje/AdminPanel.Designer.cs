namespace Proje
{
    partial class AdminPanel
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
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.btnCreateFood = new System.Windows.Forms.Button();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbProfilePhoto = new System.Windows.Forms.PictureBox();
            this.grpAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Location = new System.Drawing.Point(215, 281);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(161, 23);
            this.btnCreateCategory.TabIndex = 0;
            this.btnCreateCategory.Text = "Create New Category";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // btnCreateFood
            // 
            this.btnCreateFood.Location = new System.Drawing.Point(12, 281);
            this.btnCreateFood.Name = "btnCreateFood";
            this.btnCreateFood.Size = new System.Drawing.Size(161, 23);
            this.btnCreateFood.TabIndex = 0;
            this.btnCreateFood.Text = "Create New Food";
            this.btnCreateFood.UseVisualStyleBackColor = true;
            this.btnCreateFood.Click += new System.EventHandler(this.btnCreateFood_Click);
            // 
            // grpAdmin
            // 
            this.grpAdmin.Controls.Add(this.btnContinue);
            this.grpAdmin.Controls.Add(this.lblEmail);
            this.grpAdmin.Controls.Add(this.lblUserName);
            this.grpAdmin.Controls.Add(this.pbProfilePhoto);
            this.grpAdmin.Location = new System.Drawing.Point(12, 12);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Size = new System.Drawing.Size(364, 252);
            this.grpAdmin.TabIndex = 1;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "Admin Infos";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(100, 223);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(172, 23);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue as an User ";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(123, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 15);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "label1";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(123, 38);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(38, 15);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "label1";
            // 
            // pbProfilePhoto
            // 
            this.pbProfilePhoto.Location = new System.Drawing.Point(6, 22);
            this.pbProfilePhoto.Name = "pbProfilePhoto";
            this.pbProfilePhoto.Size = new System.Drawing.Size(100, 100);
            this.pbProfilePhoto.TabIndex = 0;
            this.pbProfilePhoto.TabStop = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 312);
            this.Controls.Add(this.grpAdmin);
            this.Controls.Add(this.btnCreateFood);
            this.Controls.Add(this.btnCreateCategory);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.grpAdmin.ResumeLayout(false);
            this.grpAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCreateCategory;
        private Button btnCreateFood;
        private GroupBox grpAdmin;
        private Label lblEmail;
        private Label lblUserName;
        private PictureBox pbProfilePhoto;
        private Button btnContinue;
    }
}