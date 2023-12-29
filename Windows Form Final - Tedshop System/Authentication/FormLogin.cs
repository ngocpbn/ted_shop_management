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


namespace Windows_Form_Final___Tedshop_System
{
    public partial class FormLogin : Form
    {
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

        static string constr = "Data Source=(localdb)\\tedshopdb;Initial Catalog=authetication_tedShopSystem;Integrated Security=True";
        static SqlConnection con = new SqlConnection(constr);

        private void Button_Login_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "select u_fullname, u_password from Users where u_username = '" + txtUsername.Text + " ' ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    sdr.Read();
                    if (sdr["u_password"].Equals(txtPassword.Text))
                    {
                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}