namespace Proje
{
    partial class AdminPanelDeneme
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
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new FontAwesome.Sharp.IconButton();
            this.homeContainer = new System.Windows.Forms.Panel();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.btnCreateCategory = new FontAwesome.Sharp.IconButton();
            this.btnCreateFood = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnContinueAsAnUser = new FontAwesome.Sharp.IconButton();
            this.sidebarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.homeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.sidebarContainer.Controls.Add(this.panel1);
            this.sidebarContainer.Controls.Add(this.homeContainer);
            this.sidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(233, 2000);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(80, 480);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(233, 525);
            this.sidebarContainer.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 137);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.menuButton.IconColor = System.Drawing.Color.White;
            this.menuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuButton.Location = new System.Drawing.Point(19, 50);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(41, 43);
            this.menuButton.TabIndex = 1;
            this.menuButton.UseVisualStyleBackColor = true;
            // 
            // homeContainer
            // 
            this.homeContainer.Controls.Add(this.btnContinueAsAnUser);
            this.homeContainer.Controls.Add(this.btnAbout);
            this.homeContainer.Controls.Add(this.btnHelp);
            this.homeContainer.Controls.Add(this.btnCreateCategory);
            this.homeContainer.Controls.Add(this.btnCreateFood);
            this.homeContainer.Location = new System.Drawing.Point(3, 146);
            this.homeContainer.MaximumSize = new System.Drawing.Size(227, 260);
            this.homeContainer.MinimumSize = new System.Drawing.Size(227, 53);
            this.homeContainer.Name = "homeContainer";
            this.homeContainer.Size = new System.Drawing.Size(227, 260);
            this.homeContainer.TabIndex = 1;
            this.homeContainer.Visible = false;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnAbout.IconColor = System.Drawing.Color.White;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.IconSize = 36;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(-3, 163);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(227, 44);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "         About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnHelp.IconColor = System.Drawing.Color.White;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHelp.IconSize = 36;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(-3, 109);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(227, 48);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "          Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.FlatAppearance.BorderSize = 0;
            this.btnCreateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateCategory.ForeColor = System.Drawing.Color.White;
            this.btnCreateCategory.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.btnCreateCategory.IconColor = System.Drawing.Color.White;
            this.btnCreateCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateCategory.IconSize = 36;
            this.btnCreateCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCategory.Location = new System.Drawing.Point(-3, 56);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCreateCategory.Size = new System.Drawing.Size(227, 47);
            this.btnCreateCategory.TabIndex = 6;
            this.btnCreateCategory.Text = "   Create Category";
            this.btnCreateCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            // 
            // btnCreateFood
            // 
            this.btnCreateFood.FlatAppearance.BorderSize = 0;
            this.btnCreateFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateFood.ForeColor = System.Drawing.Color.White;
            this.btnCreateFood.IconChar = FontAwesome.Sharp.IconChar.DrumstickBite;
            this.btnCreateFood.IconColor = System.Drawing.Color.White;
            this.btnCreateFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateFood.IconSize = 36;
            this.btnCreateFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateFood.Location = new System.Drawing.Point(-3, 3);
            this.btnCreateFood.Name = "btnCreateFood";
            this.btnCreateFood.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCreateFood.Size = new System.Drawing.Size(230, 47);
            this.btnCreateFood.TabIndex = 1;
            this.btnCreateFood.Text = "     Create Food";
            this.btnCreateFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateFood.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // btnContinueAsAnUser
            // 
            this.btnContinueAsAnUser.FlatAppearance.BorderSize = 0;
            this.btnContinueAsAnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueAsAnUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinueAsAnUser.ForeColor = System.Drawing.Color.White;
            this.btnContinueAsAnUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnContinueAsAnUser.IconColor = System.Drawing.Color.White;
            this.btnContinueAsAnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContinueAsAnUser.IconSize = 36;
            this.btnContinueAsAnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinueAsAnUser.Location = new System.Drawing.Point(-3, 213);
            this.btnContinueAsAnUser.Name = "btnContinueAsAnUser";
            this.btnContinueAsAnUser.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnContinueAsAnUser.Size = new System.Drawing.Size(227, 44);
            this.btnContinueAsAnUser.TabIndex = 7;
            this.btnContinueAsAnUser.Text = "Continue as an User ";
            this.btnContinueAsAnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinueAsAnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContinueAsAnUser.UseVisualStyleBackColor = true;
            // 
            // AdminPanelDeneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 525);
            this.Controls.Add(this.sidebarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanelDeneme";
            this.Text = "AdminPanelDeneme";
            this.sidebarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.homeContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer sidebarTimer;
        private FlowLayoutPanel sidebarContainer;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton menuButton;
        private Panel homeContainer;
        private FontAwesome.Sharp.IconButton btnCreateFood;
        private FontAwesome.Sharp.IconButton btnHelp;
        private FontAwesome.Sharp.IconButton btnAbout;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnCreateCategory;
        private FontAwesome.Sharp.IconButton btnContinueAsAnUser;
    }
}