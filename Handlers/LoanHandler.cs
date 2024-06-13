using Hulom_ClientLoan_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hulom_ClientLoan_System.Handlers
{
    internal class LoanHandler
    {
        private readonly hulomclientloandbEntities _context;
        private readonly int getCurrentClientID;
        private readonly BindingSource _source;
        public LoanHandler(BindingSource _source,int getCurrentClientID)
        {
            _context = new hulomclientloandbEntities();
            this.getCurrentClientID = getCurrentClientID;
            this._source = _source;
            _source.DataSource = _context.Loans.Where(id => id.ClientID == getCurrentClientID).ToList();
        }

        public static int GenerateNewLoanID
        {
            get
            {
                using (hulomclientloandbEntities _con = new hulomclientloandbEntities())
                {
                    return _con.Loans.Count() + 1;
                }
            }
        }

        public void AddLoan(Loan loan)
        {
            if (loan != null)
            {
                _context.Loans.Add(loan);
                _context.SaveChanges();

                _source.DataSource = _context.Loans.Where(id => id.ClientID == getCurrentClientID).ToList();
            }
        }
    }

    public abstract class LoanUtilies
    {
        public static DateTime GetDueDate(ListOfPaymentTerm t, int n)
        {
            DateTime release = DateTime.Now;

            DateTime due = release.AddDays(5);

            switch (t)
            {
                case ListOfPaymentTerm.Daily:
                    due = release.AddDays(n);
                    break;
                case ListOfPaymentTerm.Weekly:
                    due = release.AddDays(n*7);
                    break;
                case ListOfPaymentTerm.Bi_Monthly:
                    due = release.AddDays(n*15);
                    break;
                case ListOfPaymentTerm.Monthly:
                    due = release.AddMonths(n);
                    break;
                case ListOfPaymentTerm.Annualy:
                    due = release.AddYears(n);
                    break;
                default:
                    break;
            }

            return due;
        }

        public static decimal InterestedAmount(decimal loanAmount, decimal interest) => (loanAmount * interest) / 100;
        public static decimal ReceivableAmount(decimal loanAmount, decimal interestedAmount, decimal deduction) => ((loanAmount + interestedAmount) - deduction);
        public static decimal TotalPayable(decimal loanAmount, decimal interestedAmount) => (loanAmount + interestedAmount);
    }

    public enum ListOfPaymentTerm
    {
        Daily,
        Weekly,
        Bi_Monthly,
        Monthly,
        Annualy
    }
    public enum ListOfLoanStatus
    {
        Ongoing,
        Paid,
        Penalized
    }
}
