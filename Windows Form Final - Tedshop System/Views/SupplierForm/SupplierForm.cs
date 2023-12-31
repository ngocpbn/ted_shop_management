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

namespace Windows_Form_Final___Tedshop_System.Views.SupplierForm
{
    public partial class SupplierForm : Form
    {
        ISupplierRepository supplierRepository = new SupplierRepository();
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            RefreshSupplierList();
        }

        private void UpdateDataGridProducts(List<Supplier> suppliers)
        {
            dataGridSupplier.Rows.Clear();

            int i = 0;
            foreach (var supplier in suppliers)
            {
                i++;
                dataGridSupplier.Rows.Add(i, supplier.Supplier_ID, supplier.Name, supplier.Phone_num, supplier.Email, supplier.Address);
            }
        }




        public void RefreshSupplierList()
        {
            List<Supplier> suppliers = supplierRepository.GetAllSuppliers();
            dataGridSupplier.Rows.Clear();

            int i = 0;
            foreach (var supplier in suppliers)
            {
                i++;
                dataGridSupplier.Rows.Add(i, supplier.Supplier_ID, supplier.Name, supplier.Phone_num, supplier.Email, supplier.Address);
            }


        }


        private void dataGridSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridSupplier.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                int supplierId = Convert.ToInt32(dataGridSupplier.Rows[e.RowIndex].Cells["Supplier_ID"].Value);
                Supplier supplierToEdit = supplierRepository.GetSupplierByID(supplierId);
                if (supplierToEdit != null)
                {
                    SupplierModule supplierModule = new SupplierModule(supplierToEdit);
                    if (supplierModule.ShowDialog() == DialogResult.OK)
                    {
                        RefreshSupplierList();
                    }
                }
                else
                {
                    MessageBox.Show("Supplier not found.");
                }
            }
            if (colName == "Delete")
            {
                int supplierId = Convert.ToInt32(dataGridSupplier.Rows[e.RowIndex].Cells["Supplier_ID"].Value);
                Supplier supplierToDelete = supplierRepository.GetSupplierByID(supplierId);

                if (supplierToDelete != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int rowsAffected = supplierRepository.DeleteSupplier(supplierToDelete);
                        if (rowsAffected > 0)
                        {
                            RefreshSupplierList();
                            MessageBox.Show("Delete successful.");

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SupplierModule productModule = new SupplierModule(null);
            if (productModule.ShowDialog() == DialogResult.OK)
            {
                RefreshSupplierList();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            List<Supplier> filteredSupplier = supplierRepository.SearchForSupplierByName(searchText);
            UpdateDataGridProducts(filteredSupplier);
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";

            // Refresh the product list to its original state
            RefreshSupplierList();
        }
    }
}
