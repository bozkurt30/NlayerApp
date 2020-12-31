using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        private IProductService _productService;
        private ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();

            ClearProduct();
        }

        private void ClearProduct()
        {
            tbxProductAddName.Text = "";
            tbxPrice.Text = "";
            tbxQuantity.Text = "";
            tbxStock.Text = "";

            //update
            tbxUpdateProductName.Text = "";
            tbxUpdatePrice.Text = "";
            tbxUpdateQuailty.Text = "";
            tbxUpdateStock.Text = "";
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";//görünen karekter
            cbxCategory.ValueMember = "CategoryId";//onu seç,,nce de id sini lazm

            //Ekleme İşleminde Kategoriyi otomatik doldursun
            cbxCategoryAddId.DataSource = _categoryService.GetAll();
            cbxCategoryAddId.DisplayMember = "CategoryName";//görünen karekter
            cbxCategoryAddId.ValueMember = "CategoryId";//onu seç,,nce de id sini lazm

            //updateCategori
            cbxUpdateCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";//görünen karekter
            cbxUpdateCategory.ValueMember = "CategoryId";//onu seç,,nce de id sini lazm
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {
                                
            }
        }
        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAdded_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryAddId.SelectedValue),
                    ProductName = tbxProductAddName.Text,
                    QuantityPerUnit = tbxQuantity.Text,
                    UnitPrice = Convert.ToDecimal(tbxPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStock.Text)
                });
                MessageBox.Show("Ürün Kaydedildi...");
                ClearProduct();
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId= Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxUpdateProductName.Text,
                CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                UnitsInStock = Convert.ToInt16(tbxUpdateStock.Text),
                QuantityPerUnit = tbxUpdateQuailty.Text,
                UnitPrice = Convert.ToDecimal(tbxUpdatePrice.Text)
            });
            MessageBox.Show("Ürün Güncellendi...");
            ClearProduct();
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxUpdateProductName.Text = row.Cells[1].Value.ToString();
            cbxUpdateCategory.SelectedValue = row.Cells[2].Value;
            tbxUpdatePrice.Text = row.Cells[3].Value.ToString();
            tbxUpdateQuailty.Text = row.Cells[4].Value.ToString();
            tbxUpdateStock.Text = row.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün Silindi...");
                    LoadProducts();
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
               
            }
           
        }
    }
}
