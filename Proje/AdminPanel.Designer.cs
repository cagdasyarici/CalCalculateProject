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
            this.components = new System.ComponentModel.Container();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new FontAwesome.Sharp.IconButton();
            this.homeContainer = new System.Windows.Forms.Panel();
            this.btnContinueAsAnUser = new FontAwesome.Sharp.IconButton();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.btnCreateCategory = new FontAwesome.Sharp.IconButton();
            this.btnCreateFood = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShutDown = new FontAwesome.Sharp.IconButton();
            this.btnMaximizeMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.homeContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.sidebarContainer.Controls.Add(this.panel1);
            this.sidebarContainer.Controls.Add(this.homeContainer);
            this.sidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(80, 525);
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
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
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
            // btnContinueAsAnUser
            // 
            this.btnContinueAsAnUser.FlatAppearance.BorderSize = 0;
            this.btnContinueAsAnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueAsAnUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinueAsAnUser.ForeColor = System.Drawing.Color.White;
            this.btnContinueAsAnUser.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
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
            this.btnContinueAsAnUser.Click += new System.EventHandler(this.btnContinueAsAnUser_Click);
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
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
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
            this.btnCreateFood.Click += new System.EventHandler(this.btnCreateFood_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel1.Controls.Add(this.btnShutDown);
            this.flowLayoutPanel1.Controls.Add(this.btnMaximizeMinimize);
            this.flowLayoutPanel1.Controls.Add(this.btnMinimize);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(80, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 30);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPanel_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminPanel_MouseMove);
            this.flowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminPanel_MouseUp);
            // 
            // btnShutDown
            // 
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnShutDown.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnShutDown.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnShutDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShutDown.IconSize = 24;
            this.btnShutDown.Location = new System.Drawing.Point(738, 3);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(35, 27);
            this.btnShutDown.TabIndex = 0;
            this.btnShutDown.UseVisualStyleBackColor = true;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // btnMaximizeMinimize
            // 
            this.btnMaximizeMinimize.FlatAppearance.BorderSize = 0;
            this.btnMaximizeMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnMaximizeMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaximizeMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnMaximizeMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizeMinimize.IconSize = 24;
            this.btnMaximizeMinimize.Location = new System.Drawing.Point(695, 3);
            this.btnMaximizeMinimize.Name = "btnMaximizeMinimize";
            this.btnMaximizeMinimize.Size = new System.Drawing.Size(37, 27);
            this.btnMaximizeMinimize.TabIndex = 3;
            this.btnMaximizeMinimize.UseVisualStyleBackColor = true;
            this.btnMaximizeMinimize.Click += new System.EventHandler(this.btnMaximizeMinimize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 24;
            this.btnMinimize.Location = new System.Drawing.Point(652, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 27);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(292, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.sidebarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanelDeneme";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.sidebarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.homeContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnShutDown;
        private FontAwesome.Sharp.IconButton btnMaximizeMinimize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private PictureBox pictureBox1;
    }
}