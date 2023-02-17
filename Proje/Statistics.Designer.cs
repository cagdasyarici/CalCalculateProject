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
            this.dgvStatisticsTabşe = new System.Windows.Forms.DataGridView();
            this.txtTopcal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsTabşe)).BeginInit();
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
            this.rdnToplamCal.Location = new System.Drawing.Point(180, 120);
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
            this.rdnCategories.Location = new System.Drawing.Point(370, 120);
            this.rdnCategories.Name = "rdnCategories";
            this.rdnCategories.Size = new System.Drawing.Size(121, 29);
            this.rdnCategories.TabIndex = 1;
            this.rdnCategories.TabStop = true;
            this.rdnCategories.Text = "Categories";
            this.rdnCategories.UseVisualStyleBackColor = true;
            // 
            // btn_Getir
            // 
            this.btn_Getir.Location = new System.Drawing.Point(87, 182);
            this.btn_Getir.Name = "btn_Getir";
            this.btn_Getir.Size = new System.Drawing.Size(201, 49);
            this.btn_Getir.TabIndex = 2;
            this.btn_Getir.Text = "Getir";
            this.btn_Getir.UseVisualStyleBackColor = true;
            this.btn_Getir.Click += new System.EventHandler(this.btn_Getir_Click);
            // 
            // dgvStatisticsTabşe
            // 
            this.dgvStatisticsTabşe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatisticsTabşe.Location = new System.Drawing.Point(342, 182);
            this.dgvStatisticsTabşe.Name = "dgvStatisticsTabşe";
            this.dgvStatisticsTabşe.RowHeadersWidth = 62;
            this.dgvStatisticsTabşe.RowTemplate.Height = 33;
            this.dgvStatisticsTabşe.Size = new System.Drawing.Size(789, 556);
            this.dgvStatisticsTabşe.TabIndex = 3;
            // 
            // txtTopcal
            // 
            this.txtTopcal.Location = new System.Drawing.Point(166, 296);
            this.txtTopcal.Name = "txtTopcal";
            this.txtTopcal.Size = new System.Drawing.Size(150, 31);
            this.txtTopcal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Toplam Kalori : ";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTopcal);
            this.Controls.Add(this.dgvStatisticsTabşe);
            this.Controls.Add(this.btn_Getir);
            this.Controls.Add(this.rdnCategories);
            this.Controls.Add(this.rdnToplamCal);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatisticsTabşe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private RadioButton rdnToplamCal;
        private RadioButton rdnCategories;
        private Button btn_Getir;
        private DataGridView dgvStatisticsTabşe;
        private TextBox txtTopcal;
        private Label label1;
    }
}