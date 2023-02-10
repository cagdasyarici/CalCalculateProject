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


            this.cmbSecurityQuestions = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();

            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMail = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtVerificationCode = new System.Windows.Forms.TextBox();
            this.btnVerificationCode = new System.Windows.Forms.Button();
            this.txtEMailAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpChangePassword = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
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


            this.grpSecurity.Controls.Add(this.cmbSecurityQuestions);
            this.grpSecurity.Controls.Add(this.btnNext);
            this.grpSecurity.Controls.Add(this.txtSecurityAnswer);
            this.grpSecurity.Controls.Add(this.label3);

            this.grpSecurity.Controls.Add(this.label2);
            this.grpSecurity.Controls.Add(this.txtUsername);
            this.grpSecurity.Controls.Add(this.label1);
            this.grpSecurity.Location = new System.Drawing.Point(12, 12);
            this.grpSecurity.Name = "grpSecurity";
            this.grpSecurity.Size = new System.Drawing.Size(304, 426);
            this.grpSecurity.TabIndex = 0;
            this.grpSecurity.TabStop = false;
            this.grpSecurity.Text = "Security Section";
            // 


            // cmbSecurityQuestions
            // 
            this.cmbSecurityQuestions.FormattingEnabled = true;
            this.cmbSecurityQuestions.Items.AddRange(new object[] {
            "What is your first pet\'s name?",
            "What is your favorite meal?",
            "Which pokemon do you like the most?",
            "What is your best friend\'s name?"});
            this.cmbSecurityQuestions.Location = new System.Drawing.Point(145, 76);
            this.cmbSecurityQuestions.Name = "cmbSecurityQuestions";
            this.cmbSecurityQuestions.Size = new System.Drawing.Size(134, 23);
            this.cmbSecurityQuestions.TabIndex = 3;
            // 

            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(145, 154);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Location = new System.Drawing.Point(145, 115);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(134, 23);
            this.txtSecurityAnswer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Security Answer : ";
            // 


            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Security Question : ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(145, 36);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(134, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username : ";
            // 
            // grpMail
            // 
            this.grpMail.Controls.Add(this.btnApply);
            this.grpMail.Controls.Add(this.txtVerificationCode);
            this.grpMail.Controls.Add(this.btnVerificationCode);
            this.grpMail.Controls.Add(this.txtEMailAdress);
            this.grpMail.Controls.Add(this.label5);
            this.grpMail.Controls.Add(this.label4);
            this.grpMail.Location = new System.Drawing.Point(340, 23);
            this.grpMail.Name = "grpMail";
            this.grpMail.Size = new System.Drawing.Size(325, 193);
            this.grpMail.TabIndex = 1;
            this.grpMail.TabStop = false;
            this.grpMail.Text = "Mail Section";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(121, 158);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(86, 26);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.Location = new System.Drawing.Point(121, 117);
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.Size = new System.Drawing.Size(129, 23);
            this.txtVerificationCode.TabIndex = 3;
            // 
            // btnVerificationCode
            // 
            this.btnVerificationCode.Location = new System.Drawing.Point(102, 59);
            this.btnVerificationCode.Name = "btnVerificationCode";
            this.btnVerificationCode.Size = new System.Drawing.Size(164, 29);
            this.btnVerificationCode.TabIndex = 2;
            this.btnVerificationCode.Text = "Send Verification Code";
            this.btnVerificationCode.UseVisualStyleBackColor = true;
            this.btnVerificationCode.Click += new System.EventHandler(this.btnVerificationCode_Click);
            // 
            // txtEMailAdress
            // 
            this.txtEMailAdress.Location = new System.Drawing.Point(102, 22);
            this.txtEMailAdress.Name = "txtEMailAdress";
            this.txtEMailAdress.Size = new System.Drawing.Size(164, 23);
            this.txtEMailAdress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Verification Code : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "E-MailAdress : ";
            // 
            // grpChangePassword
            // 
            this.grpChangePassword.Controls.Add(this.btnChange);
            this.grpChangePassword.Controls.Add(this.txtPasswordConfirm);
            this.grpChangePassword.Controls.Add(this.label6);
            this.grpChangePassword.Controls.Add(this.txtPassword);
            this.grpChangePassword.Controls.Add(this.label7);
            this.grpChangePassword.Location = new System.Drawing.Point(340, 245);
            this.grpChangePassword.Name = "grpChangePassword";
            this.grpChangePassword.Size = new System.Drawing.Size(325, 193);
            this.grpChangePassword.TabIndex = 1;
            this.grpChangePassword.TabStop = false;
            this.grpChangePassword.Text = "Password Section";

            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(130, 103);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(86, 26);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(130, 61);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(164, 23);
            this.txtPasswordConfirm.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Confirm Password : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(164, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Password : ";
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpChangePassword);
            this.Controls.Add(this.grpMail);
            this.Controls.Add(this.grpSecurity);
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
        private Button btnNext;
        private TextBox txtSecurityAnswer;
        private Label label3;


        private Label label2;
        private TextBox txtUsername;
        private Label label1;
        private GroupBox grpMail;
        private Button btnApply;
        private TextBox txtVerificationCode;
        private Button btnVerificationCode;
        private TextBox txtEMailAdress;
        private Label label5;
        private Label label4;
        private GroupBox grpChangePassword;
        private Button btnChange;
        private TextBox txtPasswordConfirm;
        private Label label6;
        private TextBox txtPassword;
        private Label label7;


        private ComboBox cmbSecurityQuestions;

    }
}