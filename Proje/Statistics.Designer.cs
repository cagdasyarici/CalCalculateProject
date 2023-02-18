namespace Proje
{
    partial class Statistics
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.rdnToplamCal = new System.Windows.Forms.RadioButton();
            this.rdnCategories = new System.Windows.Forms.RadioButton();
            this.btn_Getir = new System.Windows.Forms.Button();
            this.dgvStatisticsTable = new System.Windows.Forms.DataGridView();
            this.rdnFiltre3 = new System.Windows.Forms.RadioButton();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.btnWeeklyReport = new System.Windows.Forms.Button();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnDailyTotalCalorie = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTotalCalForCategory = new FontAwesome.Sharp.IconButton();
            this.btnCategories = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStartDate.Location = new System.Drawing.Point(16, 21);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(240, 29);
            this.dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEndDate.Location = new System.Drawing.Point(364, 21);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(245, 29);
            this.dtpEndDate.TabIndex = 0;
            // 
            // rdnToplamCal
            // 
            this.rdnToplamCal.AutoSize = true;
            this.rdnToplamCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.rdnToplamCal.Location = new System.Drawing.Point(39, 324);
            this.rdnToplamCal.Margin = new System.Windows.Forms.Padding(2);
            this.rdnToplamCal.Name = "rdnToplamCal";
            this.rdnToplamCal.Size = new System.Drawing.Size(119, 19);
            this.rdnToplamCal.TabIndex = 1;
            this.rdnToplamCal.TabStop = true;
            this.rdnToplamCal.Text = "Daily Total Calorie";
            this.rdnToplamCal.UseVisualStyleBackColor = false;
            // 
            // rdnCategories
            // 
            this.rdnCategories.AutoSize = true;
            this.rdnCategories.Location = new System.Drawing.Point(39, 369);
            this.rdnCategories.Margin = new System.Windows.Forms.Padding(2);
            this.rdnCategories.Name = "rdnCategories";
            this.rdnCategories.Size = new System.Drawing.Size(81, 19);
            this.rdnCategories.TabIndex = 1;
            this.rdnCategories.TabStop = true;
            this.rdnCategories.Text = "Categories";
            this.rdnCategories.UseVisualStyleBackColor = true;
            // 
            // btn_Getir
            // 
            this.btn_Getir.Location = new System.Drawing.Point(32, 430);
            this.btn_Getir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Getir.Name = "btn_Getir";
            this.btn_Getir.Size = new System.Drawing.Size(141, 29);
            this.btn_Getir.TabIndex = 2;
            this.btn_Getir.Text = "Show ";
            this.btn_Getir.UseVisualStyleBackColor = true;
            this.btn_Getir.Click += new System.EventHandler(this.btn_Getir_Click);
            // 
            // dgvStatisticsTable
            // 
            this.dgvStatisticsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatisticsTable.Location = new System.Drawing.Point(220, 137);
            this.dgvStatisticsTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStatisticsTable.Name = "dgvStatisticsTable";
            this.dgvStatisticsTable.RowHeadersWidth = 62;
            this.dgvStatisticsTable.RowTemplate.Height = 33;
            this.dgvStatisticsTable.Size = new System.Drawing.Size(434, 322);
            this.dgvStatisticsTable.TabIndex = 3;
            // 
            // rdnFiltre3
            // 
            this.rdnFiltre3.AutoSize = true;
            this.rdnFiltre3.Location = new System.Drawing.Point(39, 283);
            this.rdnFiltre3.Margin = new System.Windows.Forms.Padding(2);
            this.rdnFiltre3.Name = "rdnFiltre3";
            this.rdnFiltre3.Size = new System.Drawing.Size(141, 19);
            this.rdnFiltre3.TabIndex = 6;
            this.rdnFiltre3.TabStop = true;
            this.rdnFiltre3.Text = "Total Cal For Category";
            this.rdnFiltre3.UseVisualStyleBackColor = true;
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.Location = new System.Drawing.Point(27, 137);
            this.btnDailyReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(105, 30);
            this.btnDailyReport.TabIndex = 7;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.UseVisualStyleBackColor = true;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.Location = new System.Drawing.Point(27, 204);
            this.btnMonthlyReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(105, 30);
            this.btnMonthlyReport.TabIndex = 7;
            this.btnMonthlyReport.Text = "Montly Report";
            this.btnMonthlyReport.UseVisualStyleBackColor = true;
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.Location = new System.Drawing.Point(27, 171);
            this.btnWeeklyReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(105, 30);
            this.btnWeeklyReport.TabIndex = 8;
            this.btnWeeklyReport.Text = "Weekly Report";
            this.btnWeeklyReport.UseVisualStyleBackColor = true;
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(534, 472);
            this.btnSendMail.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(128, 24);
            this.btnSendMail.TabIndex = 9;
            this.btnSendMail.Text = "Send Mail to Me";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnDailyTotalCalorie
            // 
            this.btnDailyTotalCalorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnDailyTotalCalorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDailyTotalCalorie.FlatAppearance.BorderSize = 0;
            this.btnDailyTotalCalorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyTotalCalorie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDailyTotalCalorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnDailyTotalCalorie.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnDailyTotalCalorie.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnDailyTotalCalorie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDailyTotalCalorie.IconSize = 24;
            this.btnDailyTotalCalorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailyTotalCalorie.Location = new System.Drawing.Point(16, 64);
            this.btnDailyTotalCalorie.Name = "btnDailyTotalCalorie";
            this.btnDailyTotalCalorie.Size = new System.Drawing.Size(170, 35);
            this.btnDailyTotalCalorie.TabIndex = 33;
            this.btnDailyTotalCalorie.Text = "       Daily Total Calorie";
            this.btnDailyTotalCalorie.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTotalCalForCategory);
            this.groupBox1.Controls.Add(this.btnCategories);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.btnDailyTotalCalorie);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 109);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query ";
            // 
            // btnTotalCalForCategory
            // 
            this.btnTotalCalForCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnTotalCalForCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalCalForCategory.FlatAppearance.BorderSize = 0;
            this.btnTotalCalForCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalCalForCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTotalCalForCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnTotalCalForCategory.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnTotalCalForCategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnTotalCalForCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTotalCalForCategory.IconSize = 32;
            this.btnTotalCalForCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalCalForCategory.Location = new System.Drawing.Point(409, 64);
            this.btnTotalCalForCategory.Name = "btnTotalCalForCategory";
            this.btnTotalCalForCategory.Size = new System.Drawing.Size(200, 35);
            this.btnTotalCalForCategory.TabIndex = 35;
            this.btnTotalCalForCategory.Text = "       Total Cal For Category";
            this.btnTotalCalForCategory.UseVisualStyleBackColor = false;
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnCategories.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnCategories.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategories.IconSize = 32;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(225, 64);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(161, 35);
            this.btnCategories.TabIndex = 34;
            this.btnCategories.Text = "    Categories";
            this.btnCategories.UseVisualStyleBackColor = false;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(674, 514);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdnToplamCal);
            this.Controls.Add(this.rdnCategories);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.rdnFiltre3);
            this.Controls.Add(this.btnWeeklyReport);
            this.Controls.Add(this.btnMonthlyReport);
            this.Controls.Add(this.btnDailyReport);
            this.Controls.Add(this.dgvStatisticsTable);
            this.Controls.Add(this.btn_Getir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private RadioButton rdnToplamCal;
        private RadioButton rdnCategories;
        private Button btn_Getir;
        private DataGridView dgvStatisticsTable;
        private RadioButton rdnFiltre3;
        private Button btnDailyReport;
        private Button btnMonthlyReport;
        private Button btnWeeklyReport;
        private Button btnSendMail;
        private FontAwesome.Sharp.IconButton btnDailyTotalCalorie;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnTotalCalForCategory;
        private FontAwesome.Sharp.IconButton btnCategories;
    }
}