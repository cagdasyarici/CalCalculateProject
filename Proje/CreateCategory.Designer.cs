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
            this.btnContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(203, 45);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(348, 31);
            this.txtCategoryName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Category Name:";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(203, 93);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(350, 38);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add Category Into Database";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCategories.Location = new System.Drawing.Point(0, 239);
            this.dgvCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersWidth = 62;
            this.dgvCategories.RowTemplate.Height = 25;
            this.dgvCategories.Size = new System.Drawing.Size(570, 508);
            this.dgvCategories.TabIndex = 3;
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(203, 142);
            this.btnRemoveCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(350, 38);
            this.btnRemoveCategory.TabIndex = 2;
            this.btnRemoveCategory.Text = "Remove Category From Database";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(203, 190);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(350, 38);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue as an User";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // CreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 747);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryName);
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
        private Button btnAddCategory;
        private DataGridView dgvCategories;
        private Button btnRemoveCategory;
        private Button btnContinue;
    }
}