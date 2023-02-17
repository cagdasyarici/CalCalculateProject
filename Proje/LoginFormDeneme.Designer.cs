namespace Proje
{
    partial class LoginFormDeneme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFormDeneme));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShutDown = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnSignUp = new FontAwesome.Sharp.IconButton();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.lblForgotPass = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel1.Controls.Add(this.btnShutDown);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(700, 24);
            this.flowLayoutPanel1.TabIndex = 5;
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
            this.btnShutDown.Location = new System.Drawing.Point(674, 2);
            this.btnShutDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(24, 22);
            this.btnShutDown.TabIndex = 0;
            this.btnShutDown.UseVisualStyleBackColor = true;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.ıconButton1);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Controls.Add(this.ıconButton2);
            this.panel1.Controls.Add(this.lblForgotPass);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(215, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 289);
            this.panel1.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(95, 54);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(135, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 32;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(151, 199);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 34);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "     Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ıconButton1
            // 
            this.ıconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ıconButton1.Enabled = false;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ıconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.IconSize = 36;
            this.ıconButton1.Location = new System.Drawing.Point(35, 47);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(42, 39);
            this.ıconButton1.TabIndex = 0;
            this.ıconButton1.UseVisualStyleBackColor = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnSignUp.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnSignUp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnSignUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignUp.IconSize = 32;
            this.btnSignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUp.Location = new System.Drawing.Point(24, 199);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(101, 34);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "       Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // ıconButton2
            // 
            this.ıconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ıconButton2.Enabled = false;
            this.ıconButton2.FlatAppearance.BorderSize = 0;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.ıconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.IconSize = 36;
            this.ıconButton2.Location = new System.Drawing.Point(35, 94);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Size = new System.Drawing.Size(42, 39);
            this.ıconButton2.TabIndex = 0;
            this.ıconButton2.UseVisualStyleBackColor = false;
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(172)))), ((int)(((byte)(185)))));
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.lblForgotPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.lblForgotPass.Location = new System.Drawing.Point(130, 143);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(100, 15);
            this.lblForgotPass.TabIndex = 2;
            this.lblForgotPass.TabStop = true;
            this.lblForgotPass.Text = "Forgot password?";
            this.lblForgotPass.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(45)))), ((int)(((byte)(13)))));
            this.lblForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgotPass_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(95, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // LoginFormDeneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFormDeneme";
            this.Text = "LoginFormDeneme";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnShutDown;
        private Panel panel1;
        private TextBox txtUsername;
        private FontAwesome.Sharp.IconButton btnLogin;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconButton btnSignUp;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private LinkLabel lblForgotPass;
        private TextBox txtPassword;
    }
}