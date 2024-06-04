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
using static System.Diagnostics.Debug;

namespace Hulom_ClientLoan_System.Forms.PopUpForms
{
    public partial class LoanForm : Form
    {
        private readonly LoanHandler _loanHandler;
        private readonly ScheduleHandler _scheduleHandler;
        private readonly int getSelectedClientID;
        public LoanForm(int getSelectedClientID)
        {
            InitializeComponent();
            ClientIDLabel.Text += getSelectedClientID.ToString();
            this.getSelectedClientID = getSelectedClientID;
           _loanHandler = new LoanHandler(loanBindingSource, getSelectedClientID);
            _scheduleHandler = new ScheduleHandler();
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {

        }

        private void ViewScheduleButton_Click(object sender, EventArgs e)
        {
            using (ScheduleForm s = new ScheduleForm(getSelectedLoanScheduleID, getSelectedClientID))
            {
                s.ShowDialog();
            }
        }

        private int getSelectedLoanScheduleID;
        private void LoanTable_SelectionChanged(object sender, EventArgs e)
        {
            if (LoanTable.SelectedRows.Count == 0)
            {
                return;
            }

            getSelectedLoanScheduleID = (int)LoanTable.SelectedRows[0].Cells[0].Value;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            WriteLine($"{getSelectedLoanScheduleID} : {getSelectedClientID}");
            AddLoanForm a = new AddLoanForm(getSelectedClientID);
            if (a.ShowDialog() == DialogResult.OK)
            {
                _loanHandler.AddLoan(a.GetAddedLoan);
                _scheduleHandler.AddSchedule(a.GetAddedSchedules);
            }
        }
    }
}
