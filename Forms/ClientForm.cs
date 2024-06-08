using Hulom_ClientLoan_System.Entities;
using Hulom_ClientLoan_System.Forms.PopUpForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hulom_ClientLoan_System.Forms
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
            {
                clientBindingSource.DataSource = _con.Clients.ToList();
                _con.Dispose();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddClient ae = new AddClient();
            if (ae.ShowDialog() == DialogResult.OK)
            {
                using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
                {
                    _con.Clients.Add(ae.GetAddedOrEditedClient);
                    _con.SaveChanges();
                    clientBindingSource.DataSource = _con.Clients.ToList();
                    _con.Dispose();
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
            {
                AddClient ae = new AddClient(getSelectedClientID, _con.Clients.FirstOrDefault(id => id.ID == getSelectedClientID));
                if (ae.ShowDialog() == DialogResult.OK)
                {
                    Client c = _con.Clients.FirstOrDefault(id => id.ID == getSelectedClientID);
                    if (c != null)
                    {
                        c.Firstname = ae.GetAddedOrEditedClient.Firstname;
                        c.Lastname = ae.GetAddedOrEditedClient.Lastname;
                        c.Address = ae.GetAddedOrEditedClient.Address;
                        c.Birthdate = ae.GetAddedOrEditedClient.Birthdate;
                        c.Gender = ae.GetAddedOrEditedClient.Gender;
                        c.PhoneNumber = ae.GetAddedOrEditedClient.PhoneNumber;
                        c.Email = ae.GetAddedOrEditedClient.Email;
                        c.Savings = ae.GetAddedOrEditedClient.Savings;
                        c.ActiveLoan = ae.GetAddedOrEditedClient.ActiveLoan;
                        _con.SaveChanges();
                    }
                    clientBindingSource.DataSource = _con.Clients.ToList();
                    _con.Dispose();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Do you want to delete the client ID #{getSelectedClientID}","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (r == DialogResult.Yes) {
                using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
                {
                    Client toRemove = _con.Clients.FirstOrDefault(id => id.ID == getSelectedClientID);
                    _con.Clients.Remove(toRemove);
                    _con.SaveChanges();
                    clientBindingSource.DataSource = _con.Clients.ToList();
                    _con.Dispose();
                }
            }        
        }

        private void ViewLoanButton_Click(object sender, EventArgs e)
        {
            if (getSelectedClientID > 0)
            {
                LoanForm l = new LoanForm(getSelectedClientID);
                l.ShowDialog();
                using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
                {
                    clientBindingSource.DataSource = _con.Clients.ToList();
                }
            }
            else
            {
                MessageBox.Show("Selected Client.","No",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private int getColIndex;
        private void ClientTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ClientTable.RowCount > 0)
            {
                getColIndex = e.ColumnIndex;
            }
        }

        public static int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - birthDate.Year;
            if (birthDate.Date > currentDate.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        private void ClientTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
                {
                    Client temp = _con.Clients.FirstOrDefault(id => id.ID == getSelectedClientID);
                    string showVal = $"Name: {temp.Firstname} {temp.Lastname}\nAddress: {temp.Address}\nBirthdate: {temp.Birthdate.ToString("MMM-dd-yyyyy")}\nAge: {ClientForm.CalculateAge(temp.Birthdate)}\nGender: {temp.Gender}\nPhone Number: {temp.PhoneNumber}\nEmail Address: {temp.Email}";
                    MessageBox.Show(showVal, "Member Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _con.Dispose();
                }
            }
        }

        private int getSelectedClientID;
        private void ClientTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ClientTable.SelectedRows.Count == 0)
            {
                return;
            }

            getSelectedClientID = (int)ClientTable.SelectedRows[0].Cells[0].Value;
        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            string text = SearchInput.Text.Trim();
            using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
            {
                try
                {
                    bool isId = int.TryParse(text, out int id);
                    bool isBirthDate = DateTime.TryParse(text, out DateTime birthDate);

                    var result = _con.Clients
                    .Where(c => (isId && c.ID == id) ||
                    c.Firstname.Contains(text) ||
                                    c.Lastname.Contains(text) ||
                                    c.Address.Contains(text) ||
                                    (isBirthDate && c.Birthdate == birthDate))
                        .Select(c => new
                        {
                            c.ID,
                            c.Firstname,
                            c.Lastname,
                            c.Address,
                            c.Birthdate,
                            c.Gender,
                            c.PhoneNumber,
                            c.Email,
                            c.Savings,
                            c.ActiveLoan
                        })
                        .ToList();

                    clientBindingSource.DataSource = result;
                }
                catch (Exception)
                { }
                finally
                {
                    _con.Dispose();
                }
            }
        }
    }
}
