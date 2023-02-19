namespace Proje
{
    partial class HelpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbContact = new System.Windows.Forms.RichTextBox();
            this.btnSendUs = new FontAwesome.Sharp.IconButton();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(381, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Us";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label2.Location = new System.Drawing.Point(17, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1020, 122);
            this.label2.TabIndex = 1;
            this.label2.Text = "             Do you have an issue or did you encounter a bug?             Please " +
    "contact us and we will get back to you as soon as possible.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbContact
            // 
            this.rtbContact.Location = new System.Drawing.Point(76, 343);
            this.rtbContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbContact.Name = "rtbContact";
            this.rtbContact.Size = new System.Drawing.Size(897, 522);
            this.rtbContact.TabIndex = 2;
            this.rtbContact.Text = "";
            // 
            // btnSendUs
            // 
            this.btnSendUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSendUs.FlatAppearance.BorderSize = 0;
            this.btnSendUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendUs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnSendUs.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnSendUs.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnSendUs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSendUs.IconSize = 32;
            this.btnSendUs.Location = new System.Drawing.Point(821, 878);
            this.btnSendUs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendUs.Name = "btnSendUs";
            this.btnSendUs.Size = new System.Drawing.Size(153, 65);
            this.btnSendUs.TabIndex = 4;
            this.btnSendUs.Text = "Send us";
            this.btnSendUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSendUs.UseVisualStyleBackColor = false;
            this.btnSendUs.Click += new System.EventHandler(this.btnSendUs_Click);
            // 
            // ıconButton2
            // 
            this.ıconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ıconButton2.FlatAppearance.BorderSize = 0;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ıconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Font;
            this.ıconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.IconSize = 24;
            this.ıconButton2.Location = new System.Drawing.Point(76, 275);
            this.ıconButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Size = new System.Drawing.Size(157, 58);
            this.ıconButton2.TabIndex = 5;
            this.ıconButton2.Text = "Font type";
            this.ıconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton2.UseVisualStyleBackColor = false;
            this.ıconButton2.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1054, 957);
            this.Controls.Add(this.ıconButton2);
            this.Controls.Add(this.btnSendUs);
            this.Controls.Add(this.rtbContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox rtbContact;
        private FontAwesome.Sharp.IconButton btnSendUs;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private FontDialog fontDialog1;
    }
}