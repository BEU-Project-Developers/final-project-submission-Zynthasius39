using BankingApp.UI.QuickControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp.UI
{
    public partial class PaymentsMini : UserControl
    {
        public PaymentsMini()
        {
            InitializeComponent();
        }

        private void QuickPayBtn_Click(object sender, EventArgs e)
        {
            QuickBox qb = new(new QuickPay());
            qb.Show();
        }

        private void exchangeBtn_Click(object sender, EventArgs e)
        {
            QuickBox qb = new(new Exchange());
            qb.Show();
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            QuickBox qb = new(new Transfer());
            qb.Show();
        }

        private void donateBtn_Click(object sender, EventArgs e)
        {
            QuickBox qb = new(new Donate());
            qb.Show();
        }
    }
}
