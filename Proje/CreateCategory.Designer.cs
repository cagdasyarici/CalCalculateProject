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
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategoryy = new FontAwesome.Sharp.IconButton();
            this.btnAddCategoryy = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtCategoryName.Location = new System.Drawing.Point(201, 27);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(245, 23);
            this.txtCategoryName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Category Name:";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(12, 163);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(245, 23);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add Category Into Database";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCategories.Location = new System.Drawing.Point(0, 232);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowTemplate.Height = 25;
            this.dgvCategories.Size = new System.Drawing.Size(563, 277);
            this.dgvCategories.TabIndex = 3;
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(12, 192);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(245, 23);
            this.btnRemoveCategory.TabIndex = 2;
            this.btnRemoveCategory.Text = "Remove Category From Database";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
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
            this.btnRemoveCategoryy.Location = new System.Drawing.Point(274, 192);
            this.btnRemoveCategoryy.Name = "btnRemoveCategoryy";
            this.btnRemoveCategoryy.Size = new System.Drawing.Size(277, 34);
            this.btnRemoveCategoryy.TabIndex = 4;
            this.btnRemoveCategoryy.Text = "      Remove Category From Database";
            this.btnRemoveCategoryy.UseVisualStyleBackColor = false;
            // 
            // btnAddCategoryy
            // 
            this.btnAddCategoryy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnAddCategoryy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategoryy.FlatAppearance.BorderSize = 0;
            this.btnAddCategoryy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategoryy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCategoryy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnAddCategoryy.IconChar = FontAwesome.Sharp.IconChar.SquarePlus;
            this.btnAddCategoryy.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnAddCategoryy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCategoryy.IconSize = 32;
            this.btnAddCategoryy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategoryy.Location = new System.Drawing.Point(201, 66);
            this.btnAddCategoryy.Name = "btnAddCategoryy";
            this.btnAddCategoryy.Size = new System.Drawing.Size(245, 34);
            this.btnAddCategoryy.TabIndex = 5;
            this.btnAddCategoryy.Text = "       Add Category Into Database";
            this.btnAddCategoryy.UseVisualStyleBackColor = false;
            // 
            // CreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(563, 509);
            this.Controls.Add(this.btnAddCategoryy);
            this.Controls.Add(this.btnRemoveCategoryy);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private Button btnAddCategory;
        private DataGridView dgvCategories;
        private Button btnRemoveCategory;
        private FontAwesome.Sharp.IconButton btnRemoveCategoryy;
        private FontAwesome.Sharp.IconButton btnAddCategoryy;
    }
}