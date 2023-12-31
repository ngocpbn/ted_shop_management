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
using Windows_Form_Final___Tedshop_System.Views.SupplierForm;




namespace Windows_Form_Final___Tedshop_System.Views.Dashboard
{
    public partial class Dashboard : Form
    {
        private IUserRepository userRepository = new UserRepository();
        public Dashboard()
        {
            InitializeComponent();
        }


        public void fetchData()
        {
            List<Users> users = userRepository.GetAllUsers();

            // Assuming you want to display the name of the first user
            if (users != null && users.Any())
            {
                UpdateLabelName(users.First().u_fullname);
            }
        }
        private void DashboardUI_Load(object sender, EventArgs e)
        {
            fetchData();
        }

        private void UpdateLabelName(string userName)
        {
            textNameUser.Text = userName;
        }




        private void Dashboard_Load(object sender, EventArgs e)
        {
            openChildForm(new DashboardUI());
            fetchData();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new DashboardUI());
        }



        private void btnSuplier_Click(object sender, EventArgs e)
        {
            openChildForm(new Windows_Form_Final___Tedshop_System.Views.SupplierForm.SupplierForm());
        }



        private void panelContainerForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            // Assuming ProductForm is a form and accessible
            openChildForm(new Windows_Form_Final___Tedshop_System.ProductForm()); // Replace SomeNamespace with the actual namespace where ProductForm is located
        }


        private Form activeForm;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; // Optional, to fill the panel

            // Add the form to the panel
            panelContainerForm.Controls.Add(childForm);
            panelContainerForm.Tag = childForm;


            // Bring the form to front and display it
            childForm.BringToFront();
            childForm.Show();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textNameUser_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
    
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);
    
            if (dialogResult == DialogResult.Yes)
            {
                
                // User chose to log out

                // Hide the dashboard
                this.Hide();

                // Create and show the login form
                FormLogin loginForm = new FormLogin();
                loginForm.ShowDialog();

                // Close the dashboard after logging out
                this.Close();
            }
            // If DialogResult is No, just return and do nothing
        }

    }
}

