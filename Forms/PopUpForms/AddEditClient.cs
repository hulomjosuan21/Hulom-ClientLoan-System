using Hulom_ClientLoan_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Diagnostics.Debug;

namespace Hulom_ClientLoan_System.Forms.PopUpForms
{
    public partial class AddEditClient : Form
    {
        private readonly Client tempClient;
        public AddEditClient()
        {
            InitializeComponent();
            Text = "Add Client";
            Button.Text = "Add";
            Button.Click += new EventHandler(AddButton_Click);
        }

        private readonly int getSelectedClientID;
        private readonly (decimal _Savings, int _NumLoans) GetCurrentClientSavingAndNumLoan;
        public AddEditClient(int getSelectedClientID, Client getClient)
        {
            InitializeComponent();
            Text = "Edit Client";
            Button.Text = "Save Changes";
            tempClient = getClient;
            FnameInput.Text = getClient.Firstname;
            LnameInput.Text = getClient.Lastname;
            BdayInput.Value = getClient.Birthdate;
            if (getClient.Gender.Equals("Male"))
            {
                GenderMInput.Checked = true;
            }else
            {
                GenderFInput.Checked = true;
            }
            AddressInput.Text = getClient.Address;
            EmailInput.Text = getClient.Email;
            ContactNumInput.Text = getClient.PhoneNumber;
            GetCurrentClientSavingAndNumLoan._Savings = getClient.Savings;
            GetCurrentClientSavingAndNumLoan._NumLoans = getClient.ActiveLoan;
            this.getSelectedClientID = getSelectedClientID;
            Button.Click += new EventHandler(EditButton_Click);
        }

        private void AddEditClientForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            
        }

        public Client GetAddedOrEditedClient { get; set; } = new Client();
        private void AddButton_Click(object sender, EventArgs e)
        {
            string fname = FnameInput.Text.Trim();
            string lname = LnameInput.Text.Trim();
            DateTime bday = BdayInput.Value;
            string address = AddressInput.Text.Trim();
            string email = EmailInput.Text.Trim();
            string num = ContactNumInput.Text.Trim();

            if (string.IsNullOrEmpty(fname) ||
                string.IsNullOrEmpty(lname) ||
                string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(num))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gender = string.Empty;
            if (GenderMInput.Checked)
            {
                gender = "Male";
            }
            else if (GenderFInput.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ClientForm.CalculateAge(bday) < 18)
            {
                MessageBox.Show("Invalid Gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GetAddedOrEditedClient.Firstname = fname;
            GetAddedOrEditedClient.Lastname = lname;
            GetAddedOrEditedClient.Birthdate = bday;
            GetAddedOrEditedClient.Gender = gender;
            GetAddedOrEditedClient.Address = address;
            GetAddedOrEditedClient.Email = email;
            GetAddedOrEditedClient.PhoneNumber = num;
            GetAddedOrEditedClient.Savings = 0;
            GetAddedOrEditedClient.ActiveLoan = 0;

            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void EditButton_Click(object sender, EventArgs e) {
            string fname = FnameInput.Text.Trim();
            string lname = LnameInput.Text.Trim();
            DateTime bday = BdayInput.Value;
            string address = AddressInput.Text.Trim();
            string email = EmailInput.Text.Trim();
            string num = ContactNumInput.Text.Trim();

            if (string.IsNullOrEmpty(fname) ||
                string.IsNullOrEmpty(lname) ||
                string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(num))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gender = string.Empty;
            if (GenderMInput.Checked)
            {
                gender = "Male";
            }
            else if (GenderFInput.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ClientForm.CalculateAge(bday) < 18)
            {
                MessageBox.Show("Invalid Gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GetAddedOrEditedClient.Firstname = fname;
            GetAddedOrEditedClient.Lastname = lname;
            GetAddedOrEditedClient.Birthdate = bday;
            GetAddedOrEditedClient.Gender = gender;
            GetAddedOrEditedClient.Address = address;
            GetAddedOrEditedClient.Email = email;
            GetAddedOrEditedClient.PhoneNumber = num;
            GetAddedOrEditedClient.Savings = GetCurrentClientSavingAndNumLoan._Savings;
            GetAddedOrEditedClient.ActiveLoan = GetCurrentClientSavingAndNumLoan._NumLoans;
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void EmailInput_Validating(object sender, CancelEventArgs e)
        {
            string email = EmailInput.Text;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, pattern))
            {
                if(!email.Equals(string.Empty))
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void ContactNumInput_Validating(object sender, CancelEventArgs e)
        {
            string num = ContactNumInput.Text;

            string pattern = @"^(\+?\d{1,4}?[-.\s]?(\(?\d{1,3}?\)?[-.\s]?)?\d{1,4}[-.\s]?\d{1,4}[-.\s]?\d{1,9})$";

            if (!Regex.IsMatch(num, pattern))
            {
                if (!num.Equals(string.Empty))
                {
                    MessageBox.Show("Please enter a valid phone number.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void FnameInput_Validating(object sender, CancelEventArgs e)
        {
            string name = FnameInput.Text;

            string pattern = @"^[a-zA-Z\s]+$";

            if (!Regex.IsMatch(name, pattern))
            {
                if (!name.Equals(string.Empty))
                {
                    MessageBox.Show("Please enter a valid Firstname.", "Invalid Firstname", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void LnameInput_Validating(object sender, CancelEventArgs e)
        {
            string name = LnameInput.Text;

            string pattern = @"^[a-zA-Z\s]+$";

            if (!Regex.IsMatch(name, pattern))
            {
                if (!name.Equals(string.Empty))
                {
                    MessageBox.Show("Please enter a valid lastname.", "Invalid Lastname", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void AddEditClientForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
