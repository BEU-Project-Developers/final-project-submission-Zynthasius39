using BankingApp.BLL;
using BankingApp.Models.Enums;
using MaterialSkin.Controls;
using System.Diagnostics;

namespace BankingApp.UI
{
    public partial class Dashboard : MaterialForm
    {
        public Dashboard()
        {
            InitializeComponent();
            AppSkinHelper.msm.AddFormToManage(this);
            StatusBar.AddStatusBar(mainStatus);

            if (FormHelpers.CurrentUser != null)
            {
                customerName.Text = FormHelpers.CurrentUser.Name;
                try
                {
                    FormHelpers.UserAccounts = AccountService.GetAccountsByCustomerId(FormHelpers.CurrentUser.Id);
                    FormHelpers.UserContracts = ContractService.GetContractsByType(FormHelpers.CurrentUser.Id, Contractt.Loan);

                    customerInfo.Text = string.Format(format: """
                        Net Worth: {0}
                        Total Debt: {1}
                        Active Accounts: {2}
                        Active Contracts: {3}
                        Total Transactions: {4}
                        Registered: {5}
                        """,
                        FormHelpers.UserAccounts.Sum(acc => acc.Amount),
                        FormHelpers.UserContracts.Sum(con => con.Amount),
                        FormHelpers.UserAccounts.Count,
                        FormHelpers.UserContracts.Count,
                        FormHelpers.CurrentUser.TransactionIDs.Length,
                        FormHelpers.CurrentUser.RegisterDate.ToShortDateString()
                        );

                    FormHelpers.UserAccounts.ForEach(acc =>
                        {
                            cardsTable.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, 200));
                            cardsTable.Controls.Add(FormHelpers.AddAccount(acc), 0, cardsTable.RowStyles.Count - 3);
                        });


                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    StatusBar.Status = ex.Message;
                }

            }

            // NOTE: Fetch from Database


            /*
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
            */

            mainTips.SetToolTip(logoutButton0, "Logout of your account");
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
            if (FormHelpers.CurrentUser != null)
            {
                FormHelpers.CurrentUser.Password = "";
                LogoutButton_Click(sender, e);
            }
        }

        private void PaymentsMini1_Load(object sender, EventArgs e)
        {

        }

        private void MainTips_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
