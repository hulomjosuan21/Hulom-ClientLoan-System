using Hulom_ClientLoan_System.Entities;
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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void SearchClientInput_TextChanged(object sender, EventArgs e)
        {
            using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
            {
                Client getClient = _con.Clients.FirstOrDefault(text => text.Firstname.Equals(SearchClientInput.Text.Trim()));

                if (getClient != null)
                {
                    List<Loan> getScheds = _con.Loans.Where(id => id.ClientID == getClient.ID).ToList();

                    if (getScheds != null)
                    {
                        loanBindingSource.DataSource = getScheds;
                    }
                    
                }
            }
        }

        private int getSelectedLoanID;
        private void ListofScheduleTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ListOfLoanTable.SelectedRows.Count == 0)
            {
                return;
            }

            getSelectedLoanID = (int)ListOfLoanTable.SelectedRows[0].Cells[0].Value;

            using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
            {
                List<Schedule> getScheds = _con.Schedules.Where(id => id.LoanID == getSelectedLoanID).ToList();

                if (getScheds != null)
                {
                    scheduleBindingSource.DataSource = getScheds;
                }
            }
        }

        private int getSelectedSchedID;
        private decimal getSchedCollectable;
        private void ListOfLoanSched_SelectionChanged(object sender, EventArgs e)
        {
            if (ListOfLoanSchedTable.SelectedRows.Count == 0)
            {
                return;
            }

            getSelectedSchedID = (int)ListOfLoanSchedTable.SelectedRows[0].Cells[0].Value;
            getSchedCollectable = (decimal)ListOfLoanSchedTable.SelectedRows[0].Cells[3].Value;
            TransactionInput.Text = $"{getSchedCollectable}";
        }
    }
}
