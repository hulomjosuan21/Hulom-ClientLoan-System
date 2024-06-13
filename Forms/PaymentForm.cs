using Hulom_ClientLoan_System.Entities;
using Hulom_ClientLoan_System.Handlers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hulom_ClientLoan_System.Forms
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private int getSelectedCurrentClientID;
        private void SearchClientInput_TextChanged(object sender, EventArgs e)
        {
            using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
            {
                Client getClient = _con.Clients.FirstOrDefault(text => text.Firstname.Equals(SearchClientInput.Text.Trim()));

                if (getClient != null)
                {
                    getSelectedCurrentClientID = getClient.ID;
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

        private void PayButton_Click(object sender, EventArgs e)
        {
            string text = TransactionInput.Text.Trim();
            using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
            {
                Schedule currentSched = _con.Schedules.FirstOrDefault(id => id.ID == getSelectedSchedID);
                Loan currentLoan = _con.Loans.FirstOrDefault(id => id.LoanID == getSelectedLoanID);

                if (currentLoan.TotalPayable > 0)
                {
                    if (currentSched != null && decimal.TryParse(text, out decimal paymentAmount))
                    {
                        if (paymentAmount <= currentLoan.TotalPayable)
                        {
                            decimal remainingPayment = paymentAmount;
                            currentLoan.TotalPayable -= paymentAmount;

                            if (currentLoan.TotalPayable == 0)
                            {
                                currentLoan.Status = ListOfLoanStatus.Paid.ToString();
                            }

                            while (remainingPayment > 0 && currentSched != null)
                            {
                                decimal oldCollectable = currentSched.Collectables;
                                decimal newCollectable = oldCollectable - remainingPayment;

                                if (newCollectable <= 0)
                                {
                                    remainingPayment = -newCollectable;
                                    currentSched.Collectables = 0;
                                    currentSched.Status = ListOfLoanStatus.Paid.ToString();

                                    currentSched = _con.Schedules
                                        .Where(s => s.LoanID == getSelectedLoanID && s.Status == ListOfLoanStatus.Ongoing.ToString())
                                        .OrderBy(s => s.Date)
                                        .FirstOrDefault();
                                }
                                else
                                {
                                    currentSched.Collectables = newCollectable;
                                    remainingPayment = 0;
                                }

                                _con.SaveChanges();
                            }

                            List<Schedule> schedules = _con.Schedules.Where(s => s.LoanID == getSelectedLoanID).ToList();
                            List<Loan> loans = _con.Loans.Where(id => id.ClientID == getSelectedCurrentClientID).ToList();
                            if (schedules != null)
                            {
                                scheduleBindingSource.DataSource = schedules;
                                loanBindingSource.DataSource = loans;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Payment Amount Exceed to Loan Total Payable", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This Loan is Already Paid","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
    }
}
