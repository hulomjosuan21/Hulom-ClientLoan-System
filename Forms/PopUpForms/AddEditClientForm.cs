using Hulom_ClientLoan_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hulom_ClientLoan_System.Forms.PopUpForms
{
    public partial class AddEditClientForm : Form
    {
        private Client tempClient;
        private bool editMode = false;
        public AddEditClientForm()
        {
            InitializeComponent();
            Text = "Add Client";
        }

        public AddEditClientForm(int getSelectedClientID, Client getClient) : this()
        {
            Text = "Edit Client";
            tempClient = getClient;
            editMode = true;
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

        }

        private void AddEditClientForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            
        }

        public Client GetAddedClient { get; set; } = new Client();

        private void AddButton_Click(object sender, EventArgs e)
        {
            string fname = FnameInput.Text.Trim();
            string lname = LnameInput.Text.Trim();
            DateTime bday = BdayInput.Value;

            string gender = string.Empty;
            bool[] getGender = { GenderMInput.Checked, GenderFInput.Checked };
            if (getGender[0])
            {
                gender = "Male";
            }
            if (getGender[1])
            {
                gender = "Female";
            }

            string address = AddressInput.Text.Trim();
            string email = EmailInput.Text.Trim();
            string num = ContactNumInput.Text.Trim();

            GetAddedClient.Firstname = fname;
            GetAddedClient.Lastname = lname;
            GetAddedClient.Birthdate = bday;
            GetAddedClient.Gender = gender;
            GetAddedClient.Address = address;
            GetAddedClient.Email = email;
            GetAddedClient.PhoneNumber = num;
            GetAddedClient.Savings = 0;
            GetAddedClient.ActiveLoan = 0;

            if (editMode)
            {
                if (tempClient == GetAddedClient)
                {
                    MessageBox.Show("No Changes");
                    DialogResult = DialogResult.Cancel;
                    Dispose();
                }
            }
            else
            {
                DialogResult = DialogResult.OK;
                Dispose();
            }
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
