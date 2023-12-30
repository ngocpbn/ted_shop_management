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

namespace Windows_Form_Final___Tedshop_System.Views.Dashboard
{
    public partial class DashboardUI : Form
    {
        private IBearRepository bearRepository = new BearRepository();

        private ISupplierRepository supplierRepository = new SupplierRepository();

        private IUserRepository userRepository = new UserRepository();
        public DashboardUI()
        {
            InitializeComponent();
        }

        public void fetchData()
        {
            List<Product> products = bearRepository.GetAllProducts();
            List<Supplier> suppliers = supplierRepository.GetAllSuppliers();
            List<Users> users = userRepository.GetAllUsers();

            UpdateLabelCounts(products.Count, suppliers.Count, users.Count);
        }
        private void DashboardUI_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        private void UpdateLabelCounts(int productCount, int supplierCount, int userCount)
        {
            // Set the Text properties of the labels to display counts
            numberProduct.Text = productCount.ToString();
            numberSupplier.Text = supplierCount.ToString();
            numberUser.Text = userCount.ToString();
        }

        private void numberProduct_Click(object sender, EventArgs e)
        {

        }

        private void numberSupplier_Click(object sender, EventArgs e)
        {

        }

        private void numberUser_Click(object sender, EventArgs e)
        {

        }
    }
}
