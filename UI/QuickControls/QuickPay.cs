using BankingApp.BLL;
using BankingApp.Models;
using System.Diagnostics;

namespace BankingApp.UI.QuickControls
{
    public partial class QuickPay : UserControl
    {
        private decimal _amount = 0;
        public QuickPay()
        {
            InitializeComponent();
        }

        private void AddFive_Click(object sender, EventArgs e)
        {
            _amount += 5;
            amountText.Text = _amount.ToString();
        }

        private void AddTen_Click(object sender, EventArgs e)
        {
            _amount += 10;
            amountText.Text = _amount.ToString();
        }

        private void AddFifty_Click(object sender, EventArgs e)
        {
            _amount += 50;
            amountText.Text = _amount.ToString();
        }

        private void AddHundred_Click(object sender, EventArgs e)
        {
            _amount += 100;
            amountText.Text = _amount.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            _amount = 0;
            amountText.Text = _amount.ToString();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (FormHelpers.UserDefAccount != null)
            {
                Account? dstAcc = null;
                decimal? amount = null;
                try
                {
                    dstAcc = AccountService.GetAccountByAccNum(Convert.ToInt64(destText.Text.Trim()));
                    if (dstAcc.AccountNumber == FormHelpers.UserDefAccount.AccountNumber)
                    {
                        throw new Exception("Same account");
                    }
                }
                catch
                {
                    StatusBar.Status = "Please enter valid account number!";
                }
                try
                {
                    amount = Convert.ToDecimal(amountText.Text.Trim());
                }
                catch
                {
                    StatusBar.Status = "Please enter valid account number!";
                }
                try
                {
                    if (FormHelpers.UserDefAccount != null && amount != null && dstAcc != null)
                    {
                        if (FormHelpers.UserDefAccount.Amount >= amount)
                        {
                            dstAcc.Amount += amount.Value;
                            FormHelpers.UserDefAccount.Amount -= amount.Value;
                            AccountService.UpdateAccount(dstAcc);
                            AccountService.UpdateAccount(FormHelpers.UserDefAccount);
                            StatusBar.Status = "Transfer Complete!";
                        }
                        else
                        {
                            StatusBar.Status = "Insufficient Balance";
                        }
                    }
                }
                catch (Exception ex)
                {
                    StatusBar.Status = ex.Message;
                }
            }
        }

        private void amountText_Click(object sender, EventArgs e)
        {

        }
    }
}
