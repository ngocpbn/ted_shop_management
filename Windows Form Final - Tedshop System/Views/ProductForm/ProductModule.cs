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

namespace Windows_Form_Final___Tedshop_System.Views.ProductForm
{
    public partial class ProductModule : Form
    {

        private Product currentProduct;

        IBearRepository bearRepository = new BearRepository();
        public ProductModule(Product product)
        {
            InitializeComponent();

            if (product != null)
            {
                txtName.Text = product.Name;
                txtDescription.Text = product.Description;
                txtPrice.Text = product.Price.ToString();
                txtStock.Text = product.Stock.ToString();
            }

            currentProduct = product;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }
        private void Supplier_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description is required.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price. Please enter a valid number.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Invalid stock. Please enter a valid number.");
                return;
            }

            DialogResult confirmResult = MessageBox.Show("Are you sure you want to create this product?",
                                                                    "Confirm Create", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Create a new Product instance
                Product newProduct = new Product
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Price = price,
                    Stock = stock,
                };

                // Add the new product
                int result = bearRepository.AddNewProduct(newProduct);

                if (result == 1)
                {
                    MessageBox.Show("Product added successfully!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to add product.");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentProduct == null)
            {
                MessageBox.Show("No product selected for update.");
                return;
            }

            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description is required.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price. Please enter a valid number.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Invalid stock. Please enter a valid number.");
                return;
            }
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to update this product?",
                                                                   "Confirm Update", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Update the currentProduct fields
                currentProduct.Name = txtName.Text;
                currentProduct.Description = txtDescription.Text;
                currentProduct.Price = price;
                currentProduct.Stock = stock;

                // Update the product
                int result = bearRepository.UpdateExistingProduct(currentProduct);

                if (result == 1)
                {
                    MessageBox.Show("Product updated successfully!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to update product.");
                }
            }
        }


    }
}
