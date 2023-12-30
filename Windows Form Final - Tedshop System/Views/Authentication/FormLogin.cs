using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Windows_Form_Final___Tedshop_System.Repository;
using Windows_Form_Final___Tedshop_System.BusinessObjects;
using Windows_Form_Final___Tedshop_System.DataAcess;
using Windows_Form_Final___Tedshop_System.Views.Dashboard;

namespace Windows_Form_Final___Tedshop_System
{
    public partial class FormLogin : Form
    {


        IUserRepository userRepository = new UserRepository();


        public FormLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {

        }



        private void Btn_close_Click(object sender, EventArgs e)
        {
            var window = MessageBox.Show(
                "Are you sure you want to close the application?",
                "Close Application",
                MessageBoxButtons.YesNo);

            if (window == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }


        private void Button_Login_Submit_Click(object sender, EventArgs e)
        {
            Users user = new Users
            {
                u_username = txtUsername.Text,
                u_password = txtPassword.Text
            };
            int result = userRepository.Login(user);
            if (result == 200)
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide the login form
                this.Hide();

                // Create and show the dashboard form
                Dashboard dashboard = new Dashboard();
                dashboard.Show();

                // Optionally, close the login form if it's no longer needed
                // this.Close();
            }
            else if (result == -1)
            {
                MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == -2)
            {
                MessageBox.Show("Username is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == -3)
            {
                MessageBox.Show("Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkbxShowPassword.Checked ? '\0' : '*';
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
