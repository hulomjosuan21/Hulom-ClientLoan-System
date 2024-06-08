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

        private void ScheduleTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {

                string cellValue = ScheduleTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                Color ongoingColor = Color.FromArgb(56, 146, 227);
                Color paidColor = Color.FromArgb(121, 207, 24);
                Color penalizedColor = Color.FromArgb(210, 0, 12);

                switch (cellValue)
                {
                    case "Ongoing":
                        e.CellStyle.BackColor = ongoingColor;
                        break;
                    case "Paid":
                        e.CellStyle.BackColor = paidColor;
                        break;
                    case "Penalized":
                        e.CellStyle.BackColor = penalizedColor;
                        break;
                    default:
                        e.CellStyle.BackColor = ScheduleTable.DefaultCellStyle.BackColor;
                        break;
                }
            }
        }
    }
}
