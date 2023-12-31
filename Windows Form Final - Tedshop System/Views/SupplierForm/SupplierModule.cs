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
    public partial class SupplierModule : Form
    {
        private ISupplierRepository supplierRepository = new SupplierRepository();

        private Supplier currentSupplier;

        public SupplierModule(Supplier supplier)
        {
            InitializeComponent();
            currentSupplier = supplier;
            PopulateFields();
        }
        private void PopulateFields()
        {
            if (currentSupplier != null)
            {
                txtName.Text = currentSupplier.Name;
                txtPhoneNumber.Text = currentSupplier.Phone_num;
                txtEmail.Text = currentSupplier.Email;
                txtAddress.Text = currentSupplier.Address;
            }
        }

        private void SupplierModule_Load(object sender, EventArgs e)
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

        private bool IsValidPhoneNumber(string number)
        {
            // Check if the number starts with the prefix "+84-"
            if (!number.StartsWith("+84-"))
            {
                return false; // Invalid if it doesn't start with "+84-"
            }


            string numberWithoutPrefix = number.Substring(4);

            // Check if the remaining part of the number is all digits and has a length between 10 and 12
            return numberWithoutPrefix.All(char.IsDigit) && numberWithoutPrefix.Length >= 8 && numberWithoutPrefix.Length <= 14;
        }
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            const string prefix = "+84-";
            if (!txtPhoneNumber.Text.StartsWith(prefix))
            {
                // Get only the digits from the current text
                string digitsOnly = new String(txtPhoneNumber.Text.Where(char.IsDigit).ToArray());

                // Reapply the prefix and update the text
                txtPhoneNumber.Text = prefix + digitsOnly;

                // Set the cursor position to the end of the text
                txtPhoneNumber.SelectionStart = txtPhoneNumber.Text.Length;
            }
        }


        private string FormatPhoneNumber(string number)
        {
            if (!number.StartsWith("+84-"))
            {
                return "+84-" + number;
            }
            return number;
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            if (!IsValidPhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Enter a valid phone number (numeric and 9 to 12 digits).");
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email must contain an '@' symbol.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.");
                return;
            }

            DialogResult confirmResult = MessageBox.Show("Are you sure you want to create this supplier?",
                                                                   "Confirm Create", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Supplier newSupplier = new Supplier()
                {
                    Name = txtName.Text,
                    Phone_num = FormatPhoneNumber(txtPhoneNumber.Text),
                    Email = txtEmail.Text,
                    Address = txtAddress.Text
                };

                int result = supplierRepository.AddNewSupplier(newSupplier);

                if (result == 1)
                {
                    MessageBox.Show("Supplier added successfully!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Failed to add Supplier.");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentSupplier == null)
            {
                MessageBox.Show("No supplier selected for update.");
                return;
            };
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.");
                return;
            }
            if (!IsValidPhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Enter a valid phone number (numeric and 10 to 13 digits).");
                return;
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email must contain an '@' symbol.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.");
                return;
            }


            DialogResult confirmResult = MessageBox.Show("Are you sure you want to update this supplier?",
                                                                   "Confirm Update", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                currentSupplier.Name = txtName.Text;
                currentSupplier.Phone_num = FormatPhoneNumber(txtPhoneNumber.Text);
                currentSupplier.Email = txtEmail.Text;
                currentSupplier.Address = txtAddress.Text;


                int result = supplierRepository.UpdateSupplier(currentSupplier);
                if (result == 1)
                {
                    MessageBox.Show("Supplier updated successfully!");
                    this.DialogResult = DialogResult.OK;


                }
                else
                {
                    MessageBox.Show("Failed to update supplier.");
                }
            }

        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
