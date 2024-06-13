using Hulom_ClientLoan_System.Entities;
using Hulom_ClientLoan_System.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Diagnostics.Debug;
namespace Hulom_ClientLoan_System.Forms.PopUpForms
{
    public partial class AddLoanForm : Form
    {
        private readonly int getSelectedClientID;
        public AddLoanForm(int getSelectedClientID)
        {
            InitializeComponent();

            CapitalInput.TextChanged += new EventHandler(InputChanges);
            CapitalInput.KeyPress += new KeyPressEventHandler(CatchNonNumericInput);

            InterestInput.TextChanged += new EventHandler(InputChanges);
            InterestInput.KeyPress += new KeyPressEventHandler(CatchNonNumericInput);

            PaymentTermInput.SelectedIndexChanged += new EventHandler(InputChanges);

            NoOfPaymentInput.TextChanged += new EventHandler(InputChanges);
            NoOfPaymentInput.KeyPress += new KeyPressEventHandler(CatchNonNumericInput);

            OtherFeesInput.TextChanged += new EventHandler(InputChanges);
            OtherFeesInput.KeyPress += new KeyPressEventHandler(CatchNonNumericInput);

            this.getSelectedClientID = getSelectedClientID;
        }

        private void AddLoanForm_Load(object sender, EventArgs e)
        {
            PaymentTermInput.DataSource = Enum.GetValues(typeof(ListOfPaymentTerm));
        }

        private void InputChanges(object sender, EventArgs e)
        {
            _ = Decimal.TryParse(CapitalInput.Text, out decimal loanAmt);
            _ = Decimal.TryParse(InterestInput.Text, out decimal interest);
            ListOfPaymentTerm term = (ListOfPaymentTerm) PaymentTermInput.SelectedItem;
            _ = int.TryParse(NoOfPaymentInput.Text, out int numPayment);
            _ = decimal.TryParse(OtherFeesInput.Text, out decimal deduction);

            decimal interest_amount = LoanUtilies.InterestedAmount(loanAmt, interest);
            decimal receivable_amount = LoanUtilies.ReceivableAmount(loanAmt, interest_amount, deduction);
            decimal total_payable = LoanUtilies.TotalPayable(loanAmt, interest_amount);
            DateTime due_date = LoanUtilies.GetDueDate(term, numPayment);

            string receiptText = $"Capital: {loanAmt.ToString("F2")}\nInterest: {interest.ToString("F1")}%\nPayment Term: {term}\nNo. of Payment: {numPayment}\nOther Fees: {deduction}\n\nInterest Amount: {interest_amount}\nReceivable Amount: {receivable_amount}\nTotal Payable: {total_payable}\nDuedate: {due_date.ToString("MM-dd-yyyy")}";
            ReceiptLabel.Text = receiptText;
        }

        public static void CatchNonNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public Loan GetAddedLoan { get; set; } = new Loan();
        public List<Schedule> GetAddedSchedules { get; set; } = new List<Schedule> { };

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Decimal.TryParse(CapitalInput.Text, out decimal loanAmt) || loanAmt <= 0)
                {
                    MessageBox.Show("Invalid loan amount. Please enter a valid number greater than zero.");
                    return;
                }

                _= Decimal.TryParse(InterestInput.Text, out decimal interest);

                if (!int.TryParse(NoOfPaymentInput.Text, out int numPayment) || numPayment <= 1)
                {
                    MessageBox.Show("Invalid number of payments. Please enter a valid number greater than one.");
                    return;
                }

               _= Decimal.TryParse(OtherFeesInput.Text, out decimal deduction);

                GetAddedLoan.LoanID = LoanHandler.GenerateNewLoanID;

                ListOfPaymentTerm term = (ListOfPaymentTerm)PaymentTermInput.SelectedItem;

                decimal interest_amount = LoanUtilies.InterestedAmount(loanAmt, interest);
                decimal receivable_amount = LoanUtilies.ReceivableAmount(loanAmt, interest_amount, deduction);
                decimal total_payable = LoanUtilies.TotalPayable(loanAmt, interest_amount);

                DateTime release = DateTime.Now;
                DateTime due_date = release;

                for (int i = 0; i < numPayment; i++)
                {
                    Schedule temp = new Schedule();

                    switch (term)
                    {
                        case ListOfPaymentTerm.Daily:
                            release = release.AddDays(1);
                            break;
                        case ListOfPaymentTerm.Weekly:
                            release = release.AddDays(7);
                            break;
                        case ListOfPaymentTerm.Bi_Monthly:
                            release = release.AddDays(15);
                            break;
                        case ListOfPaymentTerm.Monthly:
                            release = release.AddMonths(1);
                            break;
                        case ListOfPaymentTerm.Annualy:
                            release = release.AddYears(1);
                            break;
                        default:
                            release = release.AddDays(1);
                            break;
                    }

                    temp.LoanID = LoanHandler.GenerateNewLoanID;
                    temp.ClientID = getSelectedClientID;
                    temp.Collectables = total_payable / numPayment;
                    temp.Date = release;
                    temp.Status = ListOfLoanStatus.Ongoing.ToString();

                    GetAddedSchedules.Add(temp);

                    if (i == numPayment - 1)
                    {
                        due_date = release;
                    }
                }

                GetAddedLoan.ClientID = getSelectedClientID;
                GetAddedLoan.LoanAmount = loanAmt;
                GetAddedLoan.Interest = interest/100;
                GetAddedLoan.NoOfPayments = numPayment;
                GetAddedLoan.PaymentTerm = term.ToString();
                GetAddedLoan.Deduction = deduction;
                GetAddedLoan.InterestedAmount = interest_amount;
                GetAddedLoan.ReceivableAmount = receivable_amount;
                GetAddedLoan.TotalPayable = total_payable;
                GetAddedLoan.DueDate = due_date;
                GetAddedLoan.Status = ListOfLoanStatus.Ongoing.ToString();

                using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
                {
                    Client c = _con.Clients.FirstOrDefault(id => id.ID == getSelectedClientID);
                    c.ActiveLoan++;
                    _con.SaveChanges();
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
