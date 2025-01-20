using BankingApp.Models;
using BankingApp.Models.Enums;
using MaterialSkin.Controls;
using System.Collections;

namespace BankingApp.UI
{
    public partial class Dashboard : MaterialForm
    {
        public Dashboard()
        {

            InitializeComponent();

            IEnumerator it = TabControl.TabPages.GetEnumerator();
            while (it.MoveNext())
            {
                TabPage jt = (TabPage)it.Current;
                jt.BackColor = AppSkinHelper.msm.BackgroundColor;
            }

            Account acc = new()
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

            Payment pay = new()
            {
                Id = 0,
                Name = "AzTelekom",
                Amount = 0,
                Destination = 1234567812345678,
            };

            int cardCount = 8;
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
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new();
            loginForm.FormClosed += (sender, args) => { Close(); };
            loginForm.Show();
        }
    }
}
