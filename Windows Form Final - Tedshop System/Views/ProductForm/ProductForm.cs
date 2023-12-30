using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Form_Final___Tedshop_System.BusinessObjects;
using Windows_Form_Final___Tedshop_System.Repository;
using Windows_Form_Final___Tedshop_System.Views.ProductForm;

namespace Windows_Form_Final___Tedshop_System
{
    public partial class ProductForm : Form
    {
        IBearRepository bearRepository = new BearRepository();
        public ProductForm()
        {
            InitializeComponent();
            
        }

        public void RefreshProductList()
        {
            List<Product> products = bearRepository.GetAllProducts();
            dataGridProducts.Rows.Clear();

            int i = 0;
            foreach (var product in products)
            {
                i++;
                dataGridProducts.Rows.Add(i, product.Product_ID, product.Name, product.Description, product.Price, product.Stock,product.Supplier_ID);
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            RefreshProductList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule(null);
            if (productModule.ShowDialog() == DialogResult.OK)
            {
                RefreshProductList();
            }
        }

        private void dataGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridProducts.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                int productId = Convert.ToInt32(dataGridProducts.Rows[e.RowIndex].Cells["Product_ID"].Value);
                Product productToEdit = bearRepository.GetProductByID(productId);

                if (productToEdit != null)
                {
                    ProductModule productModule = new ProductModule(productToEdit);
                    if (productModule.ShowDialog() == DialogResult.OK)
                    {
                        RefreshProductList();
                    }
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            if(colName == "Delete")
            {
                int productId = Convert.ToInt32(dataGridProducts.Rows[e.RowIndex].Cells["Product_ID"].Value);
                Product productToDelete = bearRepository.GetProductByID(productId);

                if (productToDelete != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int rowsAffected = bearRepository.DeleteProducts(new List<Product> { productToDelete });
                        if (rowsAffected > 0)
                        {
                            RefreshProductList();
                        }
                        else
                        {
                            MessageBox.Show("Delete failed.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
        }

    }
}
