using Hulom_ClientLoan_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hulom_ClientLoan_System.Handlers
{
    internal class ScheduleHandler
    {
        private readonly hulomclientloandbEntities _context;
        private readonly BindingSource _source;

        public ScheduleHandler()
        {
            _context = new hulomclientloandbEntities();
        }

        public ScheduleHandler(BindingSource _source, int getSelectedLoanID, int getSelectedClientID): this()
        {
            _source.DataSource = _context.Schedules.Where(ids => ids.LoanID == getSelectedLoanID && ids.ClientID == getSelectedClientID).ToList();
        }

        public void AddSchedule(List<Schedule> schedules)
        {
            if (schedules != null) {
                _context.Schedules.AddRange(schedules);
                _context.SaveChanges();
            } 
        }
    }
}
