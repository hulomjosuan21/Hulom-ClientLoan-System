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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void MemberButton_Click(object sender, EventArgs e)
        {
            LoadForm(new ClientForm());
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            LoadForm(new PaymentForm());
        }

    }
}
