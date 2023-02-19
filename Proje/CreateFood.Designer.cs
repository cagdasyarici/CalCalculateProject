namespace Proje
{
    partial class CreateFood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddCategoryy = new FontAwesome.Sharp.IconButton();
            this.btnRemoveCategoryy = new FontAwesome.Sharp.IconButton();
            this.grpFoodInformations = new System.Windows.Forms.GroupBox();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.txtFat = new System.Windows.Forms.TextBox();
            this.txtProt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCarbonh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label6.Location = new System.Drawing.Point(37, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Please enter values ​​per 100 grams!";
            // 
            // btnAddCategoryy
            // 
            this.btnAddCategoryy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnAddCategoryy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategoryy.FlatAppearance.BorderSize = 0;
            this.btnAddCategoryy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategoryy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCategoryy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnAddCategoryy.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddCategoryy.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnAddCategoryy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCategoryy.IconSize = 32;
            this.btnAddCategoryy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategoryy.Location = new System.Drawing.Point(37, 298);
            this.btnAddCategoryy.Name = "btnAddCategoryy";
            this.btnAddCategoryy.Size = new System.Drawing.Size(258, 34);
            this.btnAddCategoryy.TabIndex = 24;
            this.btnAddCategoryy.Text = "       Add Food Into Database";
            this.btnAddCategoryy.UseVisualStyleBackColor = false;
            this.btnAddCategoryy.Click += new System.EventHandler(this.btnAddCategoryy_Click);
            // 
            // btnRemoveCategoryy
            // 
            this.btnRemoveCategoryy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnRemoveCategoryy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCategoryy.FlatAppearance.BorderSize = 0;
            this.btnRemoveCategoryy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCategoryy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveCategoryy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnRemoveCategoryy.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            this.btnRemoveCategoryy.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnRemoveCategoryy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveCategoryy.IconSize = 32;
            this.btnRemoveCategoryy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveCategoryy.Location = new System.Drawing.Point(321, 298);
            this.btnRemoveCategoryy.Name = "btnRemoveCategoryy";
            this.btnRemoveCategoryy.Size = new System.Drawing.Size(277, 34);
            this.btnRemoveCategoryy.TabIndex = 23;
            this.btnRemoveCategoryy.Text = "      Remove Food From Database";
            this.btnRemoveCategoryy.UseVisualStyleBackColor = false;
            this.btnRemoveCategoryy.Click += new System.EventHandler(this.btnRemoveCategoryy_Click);
            // 
            // grpFoodInformations
            // 
            this.grpFoodInformations.Location = new System.Drawing.Point(54, 33);
            this.grpFoodInformations.Name = "grpFoodInformations";
            this.grpFoodInformations.Size = new System.Drawing.Size(305, 203);
            this.grpFoodInformations.TabIndex = 26;
            this.grpFoodInformations.TabStop = false;
            this.grpFoodInformations.Text = "Food Informations";
            // 
            // dgvFood
            // 
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.dgvFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFood.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFood.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFood.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFood.EnableHeadersVisualStyles = false;
            this.dgvFood.Location = new System.Drawing.Point(0, 338);
            this.dgvFood.MultiSelect = false;
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFood.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.RowHeadersWidth = 62;
            this.dgvFood.RowTemplate.Height = 35;
            this.dgvFood.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(620, 317);
            this.dgvFood.TabIndex = 38;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(174, 249);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 29);
            this.cmbCategory.TabIndex = 50;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // txtCal
            // 
            this.txtCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtCal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCal.Location = new System.Drawing.Point(174, 209);
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(121, 22);
            this.txtCal.TabIndex = 45;
            this.txtCal.Enter += new System.EventHandler(this.txtFocus);
            this.txtCal.Leave += new System.EventHandler(this.txtFocus);
            // 
            // txtFat
            // 
            this.txtFat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtFat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFat.Location = new System.Drawing.Point(174, 168);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(121, 22);
            this.txtFat.TabIndex = 46;
            this.txtFat.Enter += new System.EventHandler(this.txtFocus);
            this.txtFat.Leave += new System.EventHandler(this.txtFocus);
            // 
            // txtProt
            // 
            this.txtProt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtProt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProt.Location = new System.Drawing.Point(174, 129);
            this.txtProt.Name = "txtProt";
            this.txtProt.Size = new System.Drawing.Size(121, 22);
            this.txtProt.TabIndex = 47;
            this.txtProt.Enter += new System.EventHandler(this.txtFocus);
            this.txtProt.Leave += new System.EventHandler(this.txtFocus);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label8.Location = new System.Drawing.Point(57, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Category:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label9.Location = new System.Drawing.Point(64, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Calories:";
            // 
            // txtCarbonh
            // 
            this.txtCarbonh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtCarbonh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarbonh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCarbonh.Location = new System.Drawing.Point(174, 89);
            this.txtCarbonh.Name = "txtCarbonh";
            this.txtCarbonh.Size = new System.Drawing.Size(121, 22);
            this.txtCarbonh.TabIndex = 48;
            this.txtCarbonh.Enter += new System.EventHandler(this.txtFocus);
            this.txtCarbonh.Leave += new System.EventHandler(this.txtFocus);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label10.Location = new System.Drawing.Point(102, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Fat:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtFoodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFoodName.Location = new System.Drawing.Point(174, 51);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(121, 22);
            this.txtFoodName.TabIndex = 49;
            this.txtFoodName.Enter += new System.EventHandler(this.txtFocus);
            this.txtFoodName.Leave += new System.EventHandler(this.txtFocus);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label11.Location = new System.Drawing.Point(72, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Protein:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label12.Location = new System.Drawing.Point(11, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Carbonhydrate:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label13.Location = new System.Drawing.Point(37, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Food Name:";
            // 
            // CreateFood
            // 
            this.AcceptButton = this.btnAddCategoryy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(620, 655);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.txtFat);
            this.Controls.Add(this.txtProt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCarbonh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.btnAddCategoryy);
            this.Controls.Add(this.btnRemoveCategoryy);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateFood";
            this.Load += new System.EventHandler(this.CreateFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private Label label6;
        private ComboBox cmbCategory;
        private FontAwesome.Sharp.IconButton btnAddCategoryy;
        private FontAwesome.Sharp.IconButton btnRemoveCategoryy;
        private GroupBox grpFoodInformations;
        private DataGridView dgvFood;
        private TextBox txtCal;
        private TextBox txtFat;
        private TextBox txtProt;
        private Label label8;
        private Label label9;
        private TextBox txtCarbonh;
        private Label label10;
        private TextBox txtFoodName;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}