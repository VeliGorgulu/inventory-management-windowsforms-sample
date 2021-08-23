
namespace InventoryManagementAppDemo.WebFormsUI
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
            this.gbxProductUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitsInStockUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitUpdate = new System.Windows.Forms.Label();
            this.lblUnitsInStockUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitsInStockAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitAdd = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblUnitsInStockAdd = new System.Windows.Forms.Label();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbxProductUpdate.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxProductUpdate
            // 
            this.gbxProductUpdate.Controls.Add(this.btnUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxUnitsInStockUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxProductUpdate.Controls.Add(this.cbxCategoryUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxProductNameUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblQuantityPerUnitUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblUnitsInStockUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblCategoryUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblProductNameUpdate);
            this.gbxProductUpdate.Location = new System.Drawing.Point(21, 498);
            this.gbxProductUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.gbxProductUpdate.Name = "gbxProductUpdate";
            this.gbxProductUpdate.Padding = new System.Windows.Forms.Padding(1);
            this.gbxProductUpdate.Size = new System.Drawing.Size(669, 141);
            this.gbxProductUpdate.TabIndex = 10;
            this.gbxProductUpdate.TabStop = false;
            this.gbxProductUpdate.Text = "Ürün güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(384, 92);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 25);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(384, 60);
            this.tbxQuantityPerUnitUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(138, 20);
            this.tbxQuantityPerUnitUpdate.TabIndex = 9;
            // 
            // tbxUnitsInStockUpdate
            // 
            this.tbxUnitsInStockUpdate.Location = new System.Drawing.Point(384, 21);
            this.tbxUnitsInStockUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.tbxUnitsInStockUpdate.Name = "tbxUnitsInStockUpdate";
            this.tbxUnitsInStockUpdate.Size = new System.Drawing.Size(138, 20);
            this.tbxUnitsInStockUpdate.TabIndex = 8;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(84, 95);
            this.tbxUnitPriceUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(164, 20);
            this.tbxUnitPriceUpdate.TabIndex = 7;
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(84, 60);
            this.cbxCategoryUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(164, 21);
            this.cbxCategoryUpdate.TabIndex = 6;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(84, 21);
            this.tbxProductNameUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(164, 20);
            this.tbxProductNameUpdate.TabIndex = 5;
            // 
            // lblQuantityPerUnitUpdate
            // 
            this.lblQuantityPerUnitUpdate.AutoSize = true;
            this.lblQuantityPerUnitUpdate.Location = new System.Drawing.Point(289, 63);
            this.lblQuantityPerUnitUpdate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblQuantityPerUnitUpdate.Name = "lblQuantityPerUnitUpdate";
            this.lblQuantityPerUnitUpdate.Size = new System.Drawing.Size(87, 13);
            this.lblQuantityPerUnitUpdate.TabIndex = 4;
            this.lblQuantityPerUnitUpdate.Text = "Quantity Per Unit";
            // 
            // lblUnitsInStockUpdate
            // 
            this.lblUnitsInStockUpdate.AutoSize = true;
            this.lblUnitsInStockUpdate.Location = new System.Drawing.Point(289, 23);
            this.lblUnitsInStockUpdate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUnitsInStockUpdate.Name = "lblUnitsInStockUpdate";
            this.lblUnitsInStockUpdate.Size = new System.Drawing.Size(74, 13);
            this.lblUnitsInStockUpdate.TabIndex = 3;
            this.lblUnitsInStockUpdate.Text = "Units In Stock";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(7, 98);
            this.lblUnitPriceUpdate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPriceUpdate.TabIndex = 2;
            this.lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Location = new System.Drawing.Point(7, 63);
            this.lblCategoryUpdate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(49, 13);
            this.lblCategoryUpdate.TabIndex = 1;
            this.lblCategoryUpdate.Text = "Category";
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(7, 23);
            this.lblProductNameUpdate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(75, 13);
            this.lblProductNameUpdate.TabIndex = 0;
            this.lblProductNameUpdate.Text = "Product Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(384, 92);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 25);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxQuantityPerUnitAdd
            // 
            this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(384, 60);
            this.tbxQuantityPerUnitAdd.Margin = new System.Windows.Forms.Padding(1);
            this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
            this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(138, 20);
            this.tbxQuantityPerUnitAdd.TabIndex = 9;
            // 
            // tbxUnitsInStockAdd
            // 
            this.tbxUnitsInStockAdd.Location = new System.Drawing.Point(384, 21);
            this.tbxUnitsInStockAdd.Margin = new System.Windows.Forms.Padding(1);
            this.tbxUnitsInStockAdd.Name = "tbxUnitsInStockAdd";
            this.tbxUnitsInStockAdd.Size = new System.Drawing.Size(138, 20);
            this.tbxUnitsInStockAdd.TabIndex = 8;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(84, 95);
            this.tbxUnitPriceAdd.Margin = new System.Windows.Forms.Padding(1);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(164, 20);
            this.tbxUnitPriceAdd.TabIndex = 7;
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(84, 60);
            this.cbxCategoryAdd.Margin = new System.Windows.Forms.Padding(1);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(164, 21);
            this.cbxCategoryAdd.TabIndex = 6;
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(84, 21);
            this.tbxProductNameAdd.Margin = new System.Windows.Forms.Padding(1);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(164, 20);
            this.tbxProductNameAdd.TabIndex = 5;
            // 
            // lblQuantityPerUnitAdd
            // 
            this.lblQuantityPerUnitAdd.AutoSize = true;
            this.lblQuantityPerUnitAdd.Location = new System.Drawing.Point(289, 63);
            this.lblQuantityPerUnitAdd.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblQuantityPerUnitAdd.Name = "lblQuantityPerUnitAdd";
            this.lblQuantityPerUnitAdd.Size = new System.Drawing.Size(87, 13);
            this.lblQuantityPerUnitAdd.TabIndex = 4;
            this.lblQuantityPerUnitAdd.Text = "Quantity Per Unit";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(567, 302);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(1);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 24);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblUnitsInStockAdd
            // 
            this.lblUnitsInStockAdd.AutoSize = true;
            this.lblUnitsInStockAdd.Location = new System.Drawing.Point(289, 23);
            this.lblUnitsInStockAdd.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUnitsInStockAdd.Name = "lblUnitsInStockAdd";
            this.lblUnitsInStockAdd.Size = new System.Drawing.Size(74, 13);
            this.lblUnitsInStockAdd.TabIndex = 3;
            this.lblUnitsInStockAdd.Text = "Units In Stock";
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(7, 98);
            this.lblUnitPriceAdd.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPriceAdd.TabIndex = 2;
            this.lblUnitPriceAdd.Text = "Unit Price";
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Location = new System.Drawing.Point(7, 63);
            this.lblCategoryAdd.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(49, 13);
            this.lblCategoryAdd.TabIndex = 1;
            this.lblCategoryAdd.Text = "Category";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitsInStockAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryAdd);
            this.gbxProductAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.lblUnitsInStockAdd);
            this.gbxProductAdd.Controls.Add(this.lblUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.lblCategoryAdd);
            this.gbxProductAdd.Controls.Add(this.lblProductNameAdd);
            this.gbxProductAdd.Location = new System.Drawing.Point(21, 337);
            this.gbxProductAdd.Margin = new System.Windows.Forms.Padding(1);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Padding = new System.Windows.Forms.Padding(1);
            this.gbxProductAdd.Size = new System.Drawing.Size(669, 141);
            this.gbxProductAdd.TabIndex = 9;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Add a new product";
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(7, 23);
            this.lblProductNameAdd.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(75, 13);
            this.lblProductNameAdd.TabIndex = 0;
            this.lblProductNameAdd.Text = "Product Name";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(94, 23);
            this.tbxProductName.Margin = new System.Windows.Forms.Padding(1);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(204, 20);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 26);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(21, 82);
            this.gbxProductName.Margin = new System.Windows.Forms.Padding(1);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Padding = new System.Windows.Forms.Padding(1);
            this.gbxProductName.Size = new System.Drawing.Size(669, 57);
            this.gbxProductName.TabIndex = 8;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Search by product name";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(94, 25);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(1);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(204, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 27);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category Name";
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.btnReset);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(21, 17);
            this.gbxCategory.Margin = new System.Windows.Forms.Padding(1);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Padding = new System.Windows.Forms.Padding(1);
            this.gbxCategory.Size = new System.Drawing.Size(669, 57);
            this.gbxCategory.TabIndex = 7;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Search by category";
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(21, 150);
            this.dgwProduct.Margin = new System.Windows.Forms.Padding(1);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowTemplate.Height = 40;
            this.dgwProduct.Size = new System.Drawing.Size(669, 142);
            this.dgwProduct.TabIndex = 6;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(302, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 21);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 656);
            this.Controls.Add(this.gbxProductUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxProductUpdate.ResumeLayout(false);
            this.gbxProductUpdate.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProductUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxUnitsInStockUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label lblQuantityPerUnitUpdate;
        private System.Windows.Forms.Label lblUnitsInStockUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
        private System.Windows.Forms.TextBox tbxUnitsInStockAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.Label lblQuantityPerUnitAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblUnitsInStockAdd;
        private System.Windows.Forms.Label lblUnitPriceAdd;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.Button btnReset;
    }
}

