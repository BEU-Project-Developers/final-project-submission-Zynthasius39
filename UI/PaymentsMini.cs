using BankingApp.BLL;
using BankingApp.Models;
using BankingApp.UI.QuickControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            if (FormHelpers.UserAccounts != null)
            {
                QuickBox qb = new(new QuickPay());
                qb.Show();
            }
            else
            {
                StatusBar.Status = "You don't have any account!";
            }
        }

        private void exchangeBtn_Click(object sender, EventArgs e)
        {
            if (FormHelpers.UserAccounts != null)
            {
                QuickBox qb = new(new Exchange());
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

        private void blockCard_Click(object sender, EventArgs e)
        {
            if (FormHelpers.UserDefAccount != null)
            {
                Debug.WriteLine(FormHelpers.UserDefAccount.ToString());
                FormHelpers.UserDefAccount.CVV = 0;
                AccountService.UpdateAccount(FormHelpers.UserDefAccount);
                StatusBar.Status = "Account frozen!";
            }
        }
    }
}
