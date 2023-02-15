namespace Proje
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMealName = new System.Windows.Forms.TextBox();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateFoodForm = new System.Windows.Forms.Button();
            this.btnShowMeals = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteMeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 61);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(267, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meal Name";
            // 
            // txtMealName
            // 
            this.txtMealName.Location = new System.Drawing.Point(107, 293);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(100, 23);
            this.txtMealName.TabIndex = 2;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Location = new System.Drawing.Point(213, 292);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(75, 23);
            this.btnAddMeal.TabIndex = 3;
            this.btnAddMeal.Text = "Add Meal";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteMeal);
            this.groupBox1.Controls.Add(this.btnCreateFoodForm);
            this.groupBox1.Controls.Add(this.btnShowMeals);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnAddMeal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMealName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 357);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meal Table";
            // 
            // btnCreateFoodForm
            // 
            this.btnCreateFoodForm.Location = new System.Drawing.Point(91, 322);
            this.btnCreateFoodForm.Name = "btnCreateFoodForm";
            this.btnCreateFoodForm.Size = new System.Drawing.Size(133, 23);
            this.btnCreateFoodForm.TabIndex = 6;
            this.btnCreateFoodForm.Text = "CreateFoodForm";
            this.btnCreateFoodForm.UseVisualStyleBackColor = true;
            this.btnCreateFoodForm.Click += new System.EventHandler(this.btnCreateFoodForm_Click);
            // 
            // btnShowMeals
            // 
            this.btnShowMeals.Location = new System.Drawing.Point(21, 264);
            this.btnShowMeals.Name = "btnShowMeals";
            this.btnShowMeals.Size = new System.Drawing.Size(100, 23);
            this.btnShowMeals.TabIndex = 5;
            this.btnShowMeals.Text = "Show Meals";
            this.btnShowMeals.UseVisualStyleBackColor = true;
            this.btnShowMeals.Click += new System.EventHandler(this.btnShowMeals_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(176, 22);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 23);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnDeleteMeal
            // 
            this.btnDeleteMeal.Location = new System.Drawing.Point(188, 263);
            this.btnDeleteMeal.Name = "btnDeleteMeal";
            this.btnDeleteMeal.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteMeal.TabIndex = 7;
            this.btnDeleteMeal.Text = "Delete Meal";
            this.btnDeleteMeal.UseVisualStyleBackColor = true;
            this.btnDeleteMeal.Click += new System.EventHandler(this.btnDeleteMeal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 384);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtMealName;
        private Button btnAddMeal;
        private GroupBox groupBox1;
        private Button btnShowMeals;
        private DateTimePicker dateTimePicker1;
        private Button btnCreateFoodForm;
        private DateTimePicker dateTimePicker2;
        private Button btnDeleteMeal;
    }
}