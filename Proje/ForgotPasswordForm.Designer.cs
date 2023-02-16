namespace Proje
{
    partial class ForgotPasswordForm
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
            this.grpSecurity = new System.Windows.Forms.GroupBox();
            this.btnNexxt = new FontAwesome.Sharp.IconButton();
            this.cmbSecurityQuestions = new System.Windows.Forms.ComboBox();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMail = new System.Windows.Forms.GroupBox();
            this.btnApplyy = new FontAwesome.Sharp.IconButton();
            this.btnSendVerificationn = new FontAwesome.Sharp.IconButton();
            this.txtVerificationCode = new System.Windows.Forms.TextBox();
            this.txtEMailAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpChangePassword = new System.Windows.Forms.GroupBox();
            this.btnChangee = new FontAwesome.Sharp.IconButton();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpSecurity.SuspendLayout();
            this.grpMail.SuspendLayout();
            this.grpChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSecurity
            // 
            this.grpSecurity.Controls.Add(this.btnNexxt);
            this.grpSecurity.Controls.Add(this.cmbSecurityQuestions);
            this.grpSecurity.Controls.Add(this.txtSecurityAnswer);
            this.grpSecurity.Controls.Add(this.label3);
            this.grpSecurity.Controls.Add(this.label2);
            this.grpSecurity.Controls.Add(this.txtUsername);
            this.grpSecurity.Controls.Add(this.label1);
            this.grpSecurity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSecurity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.grpSecurity.Location = new System.Drawing.Point(17, 20);
            this.grpSecurity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSecurity.Name = "grpSecurity";
            this.grpSecurity.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSecurity.Size = new System.Drawing.Size(434, 350);
            this.grpSecurity.TabIndex = 0;
            this.grpSecurity.TabStop = false;
            this.grpSecurity.Text = "Security Section";
            // 
            // btnNexxt
            // 
            this.btnNexxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnNexxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNexxt.FlatAppearance.BorderSize = 0;
            this.btnNexxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNexxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNexxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnNexxt.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnNexxt.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnNexxt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNexxt.IconSize = 32;
            this.btnNexxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNexxt.Location = new System.Drawing.Point(234, 258);
            this.btnNexxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNexxt.Name = "btnNexxt";
            this.btnNexxt.Size = new System.Drawing.Size(137, 53);
            this.btnNexxt.TabIndex = 31;
            this.btnNexxt.Text = "       Next";
            this.btnNexxt.UseVisualStyleBackColor = false;
            this.btnNexxt.Click += new System.EventHandler(this.btnNexxt_Click);
            // 
            // cmbSecurityQuestions
            // 
            this.cmbSecurityQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.cmbSecurityQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSecurityQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.cmbSecurityQuestions.FormattingEnabled = true;
            this.cmbSecurityQuestions.Items.AddRange(new object[] {
            "What is your first pet\'s name?",
            "What is your favorite meal?",
            "Which pokemon do you like the most?",
            "What is your best friend\'s name?"});
            this.cmbSecurityQuestions.Location = new System.Drawing.Point(234, 127);
            this.cmbSecurityQuestions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSecurityQuestions.Name = "cmbSecurityQuestions";
            this.cmbSecurityQuestions.Size = new System.Drawing.Size(190, 40);
            this.cmbSecurityQuestions.TabIndex = 3;
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtSecurityAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecurityAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.txtSecurityAnswer.Location = new System.Drawing.Point(234, 195);
            this.txtSecurityAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(191, 32);
            this.txtSecurityAnswer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Security Answer : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Security Question : ";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.txtUsername.Location = new System.Drawing.Point(234, 55);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(191, 32);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username : ";
            // 
            // grpMail
            // 
            this.grpMail.Controls.Add(this.btnApplyy);
            this.grpMail.Controls.Add(this.btnSendVerificationn);
            this.grpMail.Controls.Add(this.txtVerificationCode);
            this.grpMail.Controls.Add(this.txtEMailAdress);
            this.grpMail.Controls.Add(this.label5);
            this.grpMail.Controls.Add(this.label4);
            this.grpMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.grpMail.Location = new System.Drawing.Point(486, 20);
            this.grpMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMail.Name = "grpMail";
            this.grpMail.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMail.Size = new System.Drawing.Size(464, 322);
            this.grpMail.TabIndex = 1;
            this.grpMail.TabStop = false;
            this.grpMail.Text = "Mail Section";
            // 
            // btnApplyy
            // 
            this.btnApplyy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnApplyy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyy.FlatAppearance.BorderSize = 0;
            this.btnApplyy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApplyy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnApplyy.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnApplyy.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnApplyy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnApplyy.IconSize = 32;
            this.btnApplyy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplyy.Location = new System.Drawing.Point(267, 258);
            this.btnApplyy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplyy.Name = "btnApplyy";
            this.btnApplyy.Size = new System.Drawing.Size(137, 53);
            this.btnApplyy.TabIndex = 33;
            this.btnApplyy.Text = "       Apply";
            this.btnApplyy.UseVisualStyleBackColor = false;
            this.btnApplyy.Click += new System.EventHandler(this.btnApplyy_Click);
            // 
            // btnSendVerificationn
            // 
            this.btnSendVerificationn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSendVerificationn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendVerificationn.FlatAppearance.BorderSize = 0;
            this.btnSendVerificationn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendVerificationn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendVerificationn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnSendVerificationn.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.btnSendVerificationn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnSendVerificationn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSendVerificationn.IconSize = 32;
            this.btnSendVerificationn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendVerificationn.Location = new System.Drawing.Point(193, 90);
            this.btnSendVerificationn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendVerificationn.Name = "btnSendVerificationn";
            this.btnSendVerificationn.Size = new System.Drawing.Size(244, 53);
            this.btnSendVerificationn.TabIndex = 32;
            this.btnSendVerificationn.Text = "     Send Verification";
            this.btnSendVerificationn.UseVisualStyleBackColor = false;
            this.btnSendVerificationn.Click += new System.EventHandler(this.btnSendVerificationn_Click);
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtVerificationCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerificationCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.txtVerificationCode.Location = new System.Drawing.Point(220, 202);
            this.txtVerificationCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.Size = new System.Drawing.Size(184, 32);
            this.txtVerificationCode.TabIndex = 3;
            // 
            // txtEMailAdress
            // 
            this.txtEMailAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtEMailAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEMailAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.txtEMailAdress.Location = new System.Drawing.Point(193, 43);
            this.txtEMailAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEMailAdress.Name = "txtEMailAdress";
            this.txtEMailAdress.Size = new System.Drawing.Size(234, 32);
            this.txtEMailAdress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Verification Code : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "E-MailAdress : ";
            // 
            // grpChangePassword
            // 
            this.grpChangePassword.Controls.Add(this.btnChangee);
            this.grpChangePassword.Controls.Add(this.txtPasswordConfirm);
            this.grpChangePassword.Controls.Add(this.label6);
            this.grpChangePassword.Controls.Add(this.txtPassword);
            this.grpChangePassword.Controls.Add(this.label7);
            this.grpChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.grpChangePassword.Location = new System.Drawing.Point(486, 408);
            this.grpChangePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpChangePassword.Name = "grpChangePassword";
            this.grpChangePassword.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpChangePassword.Size = new System.Drawing.Size(464, 322);
            this.grpChangePassword.TabIndex = 1;
            this.grpChangePassword.TabStop = false;
            this.grpChangePassword.Text = "Password Section";
            // 
            // btnChangee
            // 
            this.btnChangee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnChangee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangee.FlatAppearance.BorderSize = 0;
            this.btnChangee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnChangee.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.btnChangee.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnChangee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangee.IconSize = 32;
            this.btnChangee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangee.Location = new System.Drawing.Point(220, 172);
            this.btnChangee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangee.Name = "btnChangee";
            this.btnChangee.Size = new System.Drawing.Size(184, 53);
            this.btnChangee.TabIndex = 32;
            this.btnChangee.Text = "       Change";
            this.btnChangee.UseVisualStyleBackColor = false;
            this.btnChangee.Click += new System.EventHandler(this.btnChangee_Click);
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.txtPasswordConfirm.Location = new System.Drawing.Point(220, 113);
            this.txtPasswordConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(234, 32);
            this.txtPasswordConfirm.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Confirm Password : ";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.txtPassword.Location = new System.Drawing.Point(220, 65);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(234, 32);
            this.txtPassword.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Password : ";
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.grpChangePassword);
            this.Controls.Add(this.grpMail);
            this.Controls.Add(this.grpSecurity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.grpSecurity.ResumeLayout(false);
            this.grpSecurity.PerformLayout();
            this.grpMail.ResumeLayout(false);
            this.grpMail.PerformLayout();
            this.grpChangePassword.ResumeLayout(false);
            this.grpChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpSecurity;
        private TextBox txtSecurityAnswer;
        private Label label3;


        private Label label2;
        private TextBox txtUsername;
        private Label label1;
        private GroupBox grpMail;
        private TextBox txtVerificationCode;
        private TextBox txtEMailAdress;
        private Label label5;
        private Label label4;
        private GroupBox grpChangePassword;
        private TextBox txtPasswordConfirm;
        private Label label6;
        private TextBox txtPassword;
        private Label label7;


        private ComboBox cmbSecurityQuestions;
        private FontAwesome.Sharp.IconButton btnNexxt;
        private FontAwesome.Sharp.IconButton btnApplyy;
        private FontAwesome.Sharp.IconButton btnSendVerificationn;
        private FontAwesome.Sharp.IconButton btnChangee;
    }
}