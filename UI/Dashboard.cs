using BankingApp.Models;
using BankingApp.Models.Enums;
using MaterialSkin.Controls;
using System.Collections;

namespace BankingApp.UI
{
    public partial class Dashboard : MaterialForm
    {
        private readonly Account acc = new()
        {
            AccountNumber = 1234567812345678,
            AccountType = Accountt.Credit,
            CIdList = [],
            Amount = 0,
            CreationDate = DateTime.Now,
            ExpirationDate = DateTime.Now,
            Currency = Currency.USD,
            Id = 0,
        };

        private readonly Payment pay = new()
        {
            Id = 0,
            Name = "AzTelekom",
            Amount = 0,
            Image = Properties.Resources.aztelekom,
            Destination = 1234567812345678,
        };

        private readonly Transaction tract = new()
        {
            Id = 0,
            Amount = 0,
            Currency = Currency.USD,
            Date = DateTime.Now,
            TransactionType = Transactiont.Withdrawal,
        };

        public Dashboard()
        {
            InitializeComponent();
            AppSkinHelper.msm.AddFormToManage(this);
            StatusBar.AddStatusBar(mainStatus);

            if (FormHelpers.CurrentUser != null)
            {
                customerName.Text = FormHelpers.CurrentUser.Name;
            }

            int cardCount = 6;
            for (int i = 0; i < cardCount; i++)
            {

                cardsTable.RowCount += 1;
                cardsTable.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, 200));
                cardsTable.Controls.Add(FormHelpers.AddAccount(acc), 0, i);
            }

            for (int i = 0; i < cardCount; i++)
            {
                paymentsTable.RowCount += 1;
                paymentsTable.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, 100));
                paymentsTable.Controls.Add(FormHelpers.AddPayment(pay), 0, i);
            }

            for (int i = 0; i < 5; i++)
            {
                List<Transactiont> transactiont = [
                    Transactiont.Withdrawal,
                    Transactiont.Deposit,
                    Transactiont.Exchange,
                ];
                List<Currency> currencyt = [
                    Currency.AZN,
                    Currency.USD,
                    Currency.TRY,
                ];
                tract.TransactionType = transactiont[i % 3];
                tract.Currency = currencyt[i % 3];
                transactionsTable.RowCount += 1;
                transactionsTable.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, 50));
                transactionsTable.Controls.Add(FormHelpers.AddTransaction(tract), 0, i);
            }

            mainTips.SetToolTip(logoutButton0, "Logout of your account");
            mainTips.SetToolTip(logoutButton1, "Logout of your account");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void Dashboard_SizeChanged(object sender, EventArgs e)
        {
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new();
            loginForm.FormClosed += (sender, args) => { Close(); };
            loginForm.Show();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            FormHelpers.CurrentUser.Password = "";
            LogoutButton_Click(sender, e);
        }

        private void PaymentsMini1_Load(object sender, EventArgs e)
        {

        }

        private void MainTips_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
