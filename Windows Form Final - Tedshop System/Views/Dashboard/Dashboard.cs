using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Windows_Form_Final___Tedshop_System.Views.Dashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            openChildForm(new DashboardUI());
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
    }
}

