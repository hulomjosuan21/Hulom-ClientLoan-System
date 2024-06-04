using Hulom_ClientLoan_System.Entities;
using Hulom_ClientLoan_System.Forms.PopUpForms;
using Hulom_ClientLoan_System.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hulom_ClientLoan_System.Forms
{
    public partial class ClientForm : Form
    {
        private readonly ClientHandler _clientHandler;
        public ClientForm()
        {
            InitializeComponent();
            _clientHandler = new ClientHandler(clientBindingSource);
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEditClientForm ae = new AddEditClientForm();
            if (ae.ShowDialog() == DialogResult.OK)
            {
                _clientHandler.AddClient(ae.GetAddedClient);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddEditClientForm ae = new AddEditClientForm(getSelectedClientID,_clientHandler.GetToEditClient(getSelectedClientID));
            if (ae.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show($"Do you want to delete the client ID #{getSelectedClientID}","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (r == DialogResult.Yes) {
                _clientHandler.DeleteClient(getSelectedClientID);
            }        }

        private void ViewLoanButton_Click(object sender, EventArgs e)
        {
            if (getSelectedClientID > 0)
            {
                LoanForm l = new LoanForm(getSelectedClientID);
                l.ShowDialog();
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
                DateTime bdate = (DateTime) ClientTable.Rows[e.RowIndex].Cells[4].Value;
                string rowVal = $"ID: {ClientTable.Rows[e.RowIndex].Cells[0].Value}\n" +
                    $"Name: {ClientTable.Rows[e.RowIndex].Cells[1].Value} {ClientTable.Rows[e.RowIndex].Cells[2].Value}\n" +
                    $"Address: {ClientTable.Rows[e.RowIndex].Cells[3].Value}\n" +
                    $"Birthdate {bdate.ToString("MMMM-dd-yyyy")} Age: {ClientForm.CalculateAge(bdate)}\n";
                MessageBox.Show(rowVal,"Member Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        }
    }
}
