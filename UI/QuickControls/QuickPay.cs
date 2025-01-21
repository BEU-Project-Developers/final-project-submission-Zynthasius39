using BankingApp.BLL;
using BankingApp.Models;

namespace BankingApp.UI.QuickControls
{
    public partial class QuickPay : UserControl
    {
        private Account _account;
        private decimal _amount = 0;
        public QuickPay(Account account)
        {
            _account = account;
            InitializeComponent();
        }

        private void MaterialButton4_Click(object sender, EventArgs e)
        {

        }

        private void AddFive_Click(object sender, EventArgs e)
        {
            _amount += 5;
        }

        private void AddTen_Click(object sender, EventArgs e)
        {
            _amount += 10;
        }

        private void AddFifty_Click(object sender, EventArgs e)
        {
            _amount += 50;
        }

        private void AddHundred_Click(object sender, EventArgs e)
        {
            _amount += 100;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            _amount += 0;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            _account.Amount -= _amount;
            AccountService.UpdateAccount(_account);
        }
    }
}
