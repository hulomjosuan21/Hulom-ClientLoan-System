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

namespace Hulom_ClientLoan_System.Forms.PopUpForms
{
    public partial class ScheduleForm : Form
    {
        private readonly int getClientID;
        private readonly int getLoanID;
        private readonly ScheduleHandler _scheduleHandler;
        public ScheduleForm(int getLoanID, int getClientID)
        {
            InitializeComponent();
            Text = $"Loan ID {getLoanID}";
            this.getLoanID = getLoanID;
            this.getClientID = getClientID;
            _scheduleHandler = new ScheduleHandler(scheduleBindingSource,getLoanID, getClientID);
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
