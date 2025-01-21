using BankingApp.Models;
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
        private Account? _account;
        public PaymentsMini()
        {
            InitializeComponent();
        }

        public PaymentsMini(Account account)
        {
            _account = account;
            InitializeComponent();
        }

        private void QuickPayBtn_Click(object sender, EventArgs e)
        {
            if (_account != null)
            {
                QuickBox qb = new(new QuickPay(_account));
                qb.Show();
            }
            else
            {
                StatusBar.Status = "You don't have any account!";
            }
        }

        private void exchangeBtn_Click(object sender, EventArgs e)
        {
            if (_account != null)
            {
                QuickBox qb = new(new Exchange(_account));
                qb.Show();
            }
            else
            {
                StatusBar.Status = "You don't have any account!";
            }
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
