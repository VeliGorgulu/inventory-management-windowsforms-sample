using InventoryManagementAppDemo.Business.Abstract;
using InventoryManagementAppDemo.Business.Concrete;
using InventoryManagementAppDemo.Business.DependencyResolvers.Ninject;
using InventoryManagementAppDemo.DataAccess.Concrete.EntityFramework;
using InventoryManagementAppDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementAppDemo.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }
        
        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
            cbxCategory.DataSource = _categoryService.GetAll();

            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";
            cbxCategoryAdd.DataSource = _categoryService.GetAll();

            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";
            cbxCategoryUpdate.DataSource = _categoryService.GetAll();
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                    ProductName = tbxProductNameAdd.Text,
                    QuantityPerUnit = tbxQuantityPerUnitAdd.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                    UnitsInStock = Convert.ToInt16(tbxUnitsInStockAdd.Text)
                });
                MessageBox.Show("Product added!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxProductNameUpdate.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                    UnitsInStock = Convert.ToInt16(tbxUnitsInStockUpdate.Text),
                    QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text)
                });
                MessageBox.Show("Product updated!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxProductNameUpdate.Text = row.Cells[1].Value.ToString();
            cbxCategoryUpdate.SelectedValue = row.Cells[2].Value;
            tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = row.Cells[4].Value.ToString();
            tbxUnitsInStockUpdate.Text = row.Cells[5].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Product deleted!");
                    LoadProducts();
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
