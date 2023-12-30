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
            RefreshProductList();
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




        public void RefreshProductList()
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

        }
    }
}
