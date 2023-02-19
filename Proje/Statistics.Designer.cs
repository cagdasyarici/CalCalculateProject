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
            this.dgvStatisticsTable = new System.Windows.Forms.DataGridView();
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
            this.dtpStartDate.Location = new System.Drawing.Point(23, 35);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(341, 39);
            this.dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEndDate.Location = new System.Drawing.Point(520, 35);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(348, 39);
            this.dtpEndDate.TabIndex = 0;
            // 
            // dgvStatisticsTable
            // 
            this.dgvStatisticsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatisticsTable.Location = new System.Drawing.Point(218, 228);
            this.dgvStatisticsTable.Name = "dgvStatisticsTable";
            this.dgvStatisticsTable.RowHeadersWidth = 62;
            this.dgvStatisticsTable.RowTemplate.Height = 33;
            this.dgvStatisticsTable.Size = new System.Drawing.Size(716, 537);
            this.dgvStatisticsTable.TabIndex = 3;
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.Location = new System.Drawing.Point(39, 228);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(150, 50);
            this.btnDailyReport.TabIndex = 7;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.UseVisualStyleBackColor = true;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.Location = new System.Drawing.Point(16, 381);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(173, 50);
            this.btnMonthlyReport.TabIndex = 7;
            this.btnMonthlyReport.Text = "Montly Compare";
            this.btnMonthlyReport.UseVisualStyleBackColor = true;
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyCompare_Click);
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.Location = new System.Drawing.Point(16, 326);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(173, 50);
            this.btnWeeklyReport.TabIndex = 8;
            this.btnWeeklyReport.Text = "Weekly Compare";
            this.btnWeeklyReport.UseVisualStyleBackColor = true;
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyCompare_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(751, 798);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(183, 40);
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
            this.btnDailyTotalCalorie.Location = new System.Drawing.Point(23, 107);
            this.btnDailyTotalCalorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDailyTotalCalorie.Name = "btnDailyTotalCalorie";
            this.btnDailyTotalCalorie.Size = new System.Drawing.Size(222, 58);
            this.btnDailyTotalCalorie.TabIndex = 33;
            this.btnDailyTotalCalorie.Text = "      Group By Date";
            this.btnDailyTotalCalorie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailyTotalCalorie.UseVisualStyleBackColor = false;
            this.btnDailyTotalCalorie.Click += new System.EventHandler(this.btnGroupByDate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTotalCalForCategory);
            this.groupBox1.Controls.Add(this.btnCategories);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.btnDailyTotalCalorie);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(39, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(896, 182);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serach By Date Panel";
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
            this.btnTotalCalForCategory.Location = new System.Drawing.Point(571, 107);
            this.btnTotalCalForCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTotalCalForCategory.Name = "btnTotalCalForCategory";
            this.btnTotalCalForCategory.Size = new System.Drawing.Size(297, 58);
            this.btnTotalCalForCategory.TabIndex = 35;
            this.btnTotalCalForCategory.Text = "Group By Food-Meal";
            this.btnTotalCalForCategory.UseVisualStyleBackColor = false;
            this.btnTotalCalForCategory.Click += new System.EventHandler(this.btnGroupByFoodMeal_Click);
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
            this.btnCategories.Location = new System.Drawing.Point(264, 107);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(284, 58);
            this.btnCategories.TabIndex = 34;
            this.btnCategories.Text = "Group By Category";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnGroupByCategory_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(963, 868);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.btnWeeklyReport);
            this.Controls.Add(this.btnMonthlyReport);
            this.Controls.Add(this.btnDailyReport);
            this.Controls.Add(this.dgvStatisticsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private DataGridView dgvStatisticsTable;
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