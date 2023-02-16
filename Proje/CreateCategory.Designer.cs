namespace Proje
{
    partial class CreateCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveCategoryy = new FontAwesome.Sharp.IconButton();
            this.btnAddCategoryy = new FontAwesome.Sharp.IconButton();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCategoryName.Location = new System.Drawing.Point(303, 45);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(350, 32);
            this.txtCategoryName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Category Name:";
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
            this.btnRemoveCategoryy.Location = new System.Drawing.Point(345, 306);
            this.btnRemoveCategoryy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveCategoryy.Name = "btnRemoveCategoryy";
            this.btnRemoveCategoryy.Size = new System.Drawing.Size(446, 45);
            this.btnRemoveCategoryy.TabIndex = 4;
            this.btnRemoveCategoryy.Text = "      Remove Category From Database";
            this.btnRemoveCategoryy.UseVisualStyleBackColor = false;
            this.btnRemoveCategoryy.Click += new System.EventHandler(this.btnRemoveCategoryy_Click);
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
            this.btnAddCategoryy.Location = new System.Drawing.Point(378, 106);
            this.btnAddCategoryy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCategoryy.Name = "btnAddCategoryy";
            this.btnAddCategoryy.Size = new System.Drawing.Size(275, 46);
            this.btnAddCategoryy.TabIndex = 5;
            this.btnAddCategoryy.Text = "       Add Category Into Database";
            this.btnAddCategoryy.UseVisualStyleBackColor = false;
            this.btnAddCategoryy.Click += new System.EventHandler(this.btnAddCategoryy_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCategories.EnableHeadersVisualStyles = false;
            this.dgvCategories.Location = new System.Drawing.Point(0, 373);
            this.dgvCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.RowHeadersWidth = 62;
            this.dgvCategories.RowTemplate.Height = 35;
            this.dgvCategories.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(804, 475);
            this.dgvCategories.TabIndex = 10;
            // 
            // CreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(804, 848);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.btnAddCategoryy);
            this.Controls.Add(this.btnRemoveCategoryy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateCategory";
            this.Text = "CreateCategory";
            this.Load += new System.EventHandler(this.CreateCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCategoryName;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnRemoveCategoryy;
        private FontAwesome.Sharp.IconButton btnAddCategoryy;
        private DataGridView dgvCategories;
    }
}