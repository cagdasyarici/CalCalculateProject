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
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(121, 44);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(300, 31);
            this.dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(584, 44);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(300, 31);
            this.dtpEndDate.TabIndex = 0;
            // 
            // rdnToplamCal
            // 
            this.rdnToplamCal.AutoSize = true;
            this.rdnToplamCal.Location = new System.Drawing.Point(341, 118);
            this.rdnToplamCal.Name = "rdnToplamCal";
            this.rdnToplamCal.Size = new System.Drawing.Size(90, 29);
            this.rdnToplamCal.TabIndex = 1;
            this.rdnToplamCal.TabStop = true;
            this.rdnToplamCal.Text = "TopCal";
            this.rdnToplamCal.UseVisualStyleBackColor = true;
            // 
            // rdnCategories
            // 
            this.rdnCategories.AutoSize = true;
            this.rdnCategories.Location = new System.Drawing.Point(461, 118);
            this.rdnCategories.Name = "rdnCategories";
            this.rdnCategories.Size = new System.Drawing.Size(121, 29);
            this.rdnCategories.TabIndex = 1;
            this.rdnCategories.TabStop = true;
            this.rdnCategories.Text = "Categories";
            this.rdnCategories.UseVisualStyleBackColor = true;
            // 
            // btn_Getir
            // 
            this.btn_Getir.Location = new System.Drawing.Point(114, 182);
            this.btn_Getir.Name = "btn_Getir";
            this.btn_Getir.Size = new System.Drawing.Size(201, 49);
            this.btn_Getir.TabIndex = 2;
            this.btn_Getir.Text = "Getir";
            this.btn_Getir.UseVisualStyleBackColor = true;
            this.btn_Getir.Click += new System.EventHandler(this.btn_Getir_Click);
            // 
            // dgvStatisticsTable
            // 
            this.dgvStatisticsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatisticsTable.Location = new System.Drawing.Point(342, 182);
            this.dgvStatisticsTable.Name = "dgvStatisticsTable";
            this.dgvStatisticsTable.RowHeadersWidth = 62;
            this.dgvStatisticsTable.RowTemplate.Height = 33;
            this.dgvStatisticsTable.Size = new System.Drawing.Size(789, 556);
            this.dgvStatisticsTable.TabIndex = 3;
            // 
            // rdnFiltre3
            // 
            this.rdnFiltre3.AutoSize = true;
            this.rdnFiltre3.Location = new System.Drawing.Point(598, 118);
            this.rdnFiltre3.Name = "rdnFiltre3";
            this.rdnFiltre3.Size = new System.Drawing.Size(85, 29);
            this.rdnFiltre3.TabIndex = 6;
            this.rdnFiltre3.TabStop = true;
            this.rdnFiltre3.Text = "Filtre3";
            this.rdnFiltre3.UseVisualStyleBackColor = true;
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.Location = new System.Drawing.Point(165, 257);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(150, 50);
            this.btnDailyReport.TabIndex = 7;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.UseVisualStyleBackColor = true;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.Location = new System.Drawing.Point(165, 369);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(150, 50);
            this.btnMonthlyReport.TabIndex = 7;
            this.btnMonthlyReport.Text = "Montly Report";
            this.btnMonthlyReport.UseVisualStyleBackColor = true;
            this.btnMonthlyReport.Click += new System.EventHandler(this.btnMonthlyReport_Click);
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.Location = new System.Drawing.Point(165, 313);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(150, 50);
            this.btnWeeklyReport.TabIndex = 8;
            this.btnWeeklyReport.Text = "Weekly Report";
            this.btnWeeklyReport.UseVisualStyleBackColor = true;
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(839, 118);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(274, 40);
            this.btnSendMail.TabIndex = 9;
            this.btnSendMail.Text = "Send Mail to Me";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.btnWeeklyReport);
            this.Controls.Add(this.btnMonthlyReport);
            this.Controls.Add(this.btnDailyReport);
            this.Controls.Add(this.rdnFiltre3);
            this.Controls.Add(this.dgvStatisticsTable);
            this.Controls.Add(this.btn_Getir);
            this.Controls.Add(this.rdnCategories);
            this.Controls.Add(this.rdnToplamCal);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsTable)).EndInit();
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
    }
}