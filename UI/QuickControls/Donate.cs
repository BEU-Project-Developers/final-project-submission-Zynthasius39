using BankingApp.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp.UI.QuickControls
{
    public partial class Donate : UserControl
    {
        private int _amount = 0;
        public Donate()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (FormHelpers.UserDefAccount != null) {
                if (FormHelpers.UserDefAccount.Amount >= _amount)
                {
                    FormHelpers.UserDefAccount.Amount -= _amount;
                    AccountService.UpdateAccount(FormHelpers.UserDefAccount);
                    StatusBar.Status = "Thank you for your donation!";
                }
                else
                    StatusBar.Status = "Insufficient Balance";
            }
        }

        private void addBtn0_Click(object sender, EventArgs e)
        {
            _amount += 5;
            amountText.Text = _amount.ToString();
        }

        private void addBtn1_Click(object sender, EventArgs e)
        {
            _amount += 10;
            amountText.Text = _amount.ToString();
        }

        private void addBtn2_Click(object sender, EventArgs e)
        {
            _amount += 50;
            amountText.Text = _amount.ToString();
        }

        private void addBtn3_Click(object sender, EventArgs e)
        {
            _amount += 100;
            amountText.Text = _amount.ToString();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            _amount = 0;
            amountText.Text = _amount.ToString();
        }
    }
}
