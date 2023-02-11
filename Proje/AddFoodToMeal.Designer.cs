namespace Proje
{
    partial class AddFoodToMeal
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgv_MealDetails = new System.Windows.Forms.DataGridView();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_FoodList = new System.Windows.Forms.DataGridView();
            this.txtGrams = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddMealDetail = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MealDetails)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FoodList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Delete);
            this.groupBox4.Controls.Add(this.dgv_MealDetails);
            this.groupBox4.Controls.Add(this.btnAddMeal);
            this.groupBox4.Location = new System.Drawing.Point(17, 20);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(699, 617);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Meal Details";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(572, 350);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(107, 45);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgv_MealDetails
            // 
            this.dgv_MealDetails.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dgv_MealDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MealDetails.Location = new System.Drawing.Point(9, 37);
            this.dgv_MealDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_MealDetails.Name = "dgv_MealDetails";
            this.dgv_MealDetails.RowHeadersWidth = 62;
            this.dgv_MealDetails.RowTemplate.Height = 25;
            this.dgv_MealDetails.Size = new System.Drawing.Size(670, 303);
            this.dgv_MealDetails.TabIndex = 7;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Location = new System.Drawing.Point(9, 550);
            this.btnAddMeal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(110, 45);
            this.btnAddMeal.TabIndex = 4;
            this.btnAddMeal.Text = "Add Meal";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_FoodList);
            this.groupBox2.Controls.Add(this.txtGrams);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAddMealDetail);
            this.groupBox2.Location = new System.Drawing.Point(724, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(734, 617);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food List";
            // 
            // dgv_FoodList
            // 
            this.dgv_FoodList.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgv_FoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FoodList.Location = new System.Drawing.Point(30, 92);
            this.dgv_FoodList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_FoodList.Name = "dgv_FoodList";
            this.dgv_FoodList.RowHeadersWidth = 62;
            this.dgv_FoodList.RowTemplate.Height = 25;
            this.dgv_FoodList.Size = new System.Drawing.Size(649, 418);
            this.dgv_FoodList.TabIndex = 1;
            // 
            // txtGrams
            // 
            this.txtGrams.Location = new System.Drawing.Point(296, 537);
            this.txtGrams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGrams.Name = "txtGrams";
            this.txtGrams.Size = new System.Drawing.Size(163, 31);
            this.txtGrams.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(417, 43);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 31);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 550);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "How many grams did you eat?";
            // 
            // btnAddMealDetail
            // 
            this.btnAddMealDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMealDetail.Location = new System.Drawing.Point(469, 525);
            this.btnAddMealDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMealDetail.Name = "btnAddMealDetail";
            this.btnAddMealDetail.Size = new System.Drawing.Size(210, 50);
            this.btnAddMealDetail.TabIndex = 8;
            this.btnAddMealDetail.Text = "Add Meal Detail";
            this.btnAddMealDetail.UseVisualStyleBackColor = true;
            this.btnAddMealDetail.Click += new System.EventHandler(this.btnAddMealDetail_Click);
            // 
            // AddFoodToMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 633);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddFoodToMeal";
            this.Text = "AddFoodToMeal";
            this.Load += new System.EventHandler(this.AddFoodToMeal_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MealDetails)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FoodList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox4;
        private DataGridView dgv_MealDetails;
        private Button btnOgunEkle;
        private GroupBox groupBox2;
        private DataGridView dgv_FoodList;
        private TextBox txtGrams;
        private TextBox txtSearch;
        private Label label2;
        private Button button1;
        private Button btnAddMeal;
        private Button btnAddMealDetail;
        private Button btn_Delete;
    }
}