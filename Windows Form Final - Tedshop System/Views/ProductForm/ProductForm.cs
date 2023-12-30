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
            PopulateComboBoxes();

        }

        private void PopulateComboBoxes()
        {
            // Add "All" option as the first item for comboBoxCategory
            comboBoxCategory.Items.Add("Category (All)");
            comboBoxCategory.Items.AddRange(new object[] { "Cat", "Dog", "Bear", "Pig" });
            comboBoxCategory.SelectedIndex = 0; // Set "All" as the default selected item

            // Add "All" option as the first item for comboBoxSize
            comboBoxSize.Items.Add("Size (All)");
            comboBoxSize.Items.AddRange(new object[] { "M", "S", "L", "XL" });
            comboBoxSize.SelectedIndex = 0; // Set "All" as the default selected item
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            RefreshProductList();
        }


        private void UpdateDataGridProducts(List<Product> products)
        {
            dataGridProducts.Rows.Clear();

            int i = 0;
            foreach (var product in products)
            {
                i++;
                dataGridProducts.Rows.Add(i, product.Product_ID, product.Name, product.Description, product.Price, product.Stock, product.Size, product.Category, product.Supplier_ID);
            }
        }




        public void RefreshProductList()
        {
            List<Product> products = bearRepository.GetAllProducts();
            dataGridProducts.Rows.Clear();

            int i = 0;
            foreach (var product in products)
            {
                i++;
                dataGridProducts.Rows.Add(i, product.Product_ID, product.Name, product.Description, product.Price, product.Stock, product.Size, product.Category, product.Supplier_ID);
            }


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
            if (colName == "Delete")
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            List<Product> filteredProducts = bearRepository.SearchForProductsByName(searchText);
            UpdateDataGridProducts(filteredProducts);
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected category, treat "Category (All)" as no filter
            string selectedCategory = comboBoxCategory.SelectedItem.ToString();
            if (selectedCategory == "Category (All)") selectedCategory = "";

            // Get the selected size, or no size filter if none is selected or "Size (All)" is selected
            string selectedSize = comboBoxSize.SelectedItem?.ToString() ?? "";
            if (selectedSize == "Size (All)") selectedSize = "";

            // Perform the product search with the current filter settings
            List<Product> filteredProducts = bearRepository.SearchProductSByNameSizeCate(txtSearch.Text, selectedSize, selectedCategory);
            UpdateDataGridProducts(filteredProducts);
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected size, treat "Size (All)" as no filter
            string selectedSize = comboBoxSize.SelectedItem.ToString();
            if (selectedSize == "Size (All)") selectedSize = "";

            // Get the selected category, or no category filter if none is selected or "Category (All)" is selected
            string selectedCategory = comboBoxCategory.SelectedItem?.ToString() ?? "";
            if (selectedCategory == "Category (All)") selectedCategory = "";

            // Perform the product search with the current filter settings
            List<Product> filteredProducts = bearRepository.SearchProductSByNameSizeCate(txtSearch.Text, selectedSize, selectedCategory);
            UpdateDataGridProducts(filteredProducts);
        }


        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            comboBoxCategory.SelectedIndex = 0; // No item selected
            comboBoxSize.SelectedIndex = 0;    // No item selected

            // Clear the search text box if you have one
            txtSearch.Text = "";

            // Refresh the product list to its original state
            RefreshProductList();
        }
    }
}
