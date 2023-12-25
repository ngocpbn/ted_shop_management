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

namespace Windows_Form_Final___Tedshop_System
{
    public partial class FormLogin : Form
    {
 
        IAppRepository appRepository = new AppRepository();

        public FormLogin()
        {
            InitializeComponent();
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
                
                int result = appRepository.Login(txtUsername.Text, txtPassword.Text);
                if (result == 200)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (result == -1)
                {
                    MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (result == -2)
                {
                    MessageBox.Show("Username is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (result == -3)
                {
                    MessageBox.Show("Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
