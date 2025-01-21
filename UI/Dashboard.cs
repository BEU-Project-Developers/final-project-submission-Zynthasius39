using BankingApp.BLL;
using BankingApp.Models.Enums;
using MaterialSkin.Controls;
using System.Diagnostics;

namespace BankingApp.UI
{
    public partial class Dashboard : MaterialForm
    {
        private readonly TableLayoutPanel _payments, _cards, _transactions;
        public Dashboard()
        {
            InitializeComponent();
            AppSkinHelper.msm.AddFormToManage(this);
            StatusBar.AddStatusBar(mainStatus);

            _payments = paymentsTable;
            _cards = cardsTable;
            _transactions = transactionsTable;
            Dashboard_Load();

            mainTips.SetToolTip(logoutButton0, "Logout of your account");
        }

        private void Dashboard_Load()
        {
            try
            {
                profilePic.Image = new Bitmap(FormHelpers.PATH + @"\user.png");
                FormHelpers.Payments = PaymentService.GetAllPayments();

                if (FormHelpers.CurrentUser != null)
                {
                    customerName.Text = FormHelpers.CurrentUser.Name;
                    FormHelpers.UserAccounts = AccountService.GetAccountsByCustomerId(FormHelpers.CurrentUser.Id);
                    FormHelpers.UserContracts = ContractService.GetContractsByType(FormHelpers.CurrentUser.Id, Contractt.Loan);
                    FormHelpers.UserTransactions = TransactionService.GetTransactionsByCustomer(FormHelpers.CurrentUser);

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

                    cardsTable = _cards;
                    FormHelpers.UserAccounts.ForEach(acc =>
                        {
                            cardsTable.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, 200));
                            cardsTable.Controls.Add(FormHelpers.AddAccount(acc), 0, cardsTable.RowStyles.Count - 3);
                        });

                    transactionsTable = _transactions;
                    FormHelpers.UserTransactions.ForEach(tx =>
                        {
                            transactionsTable.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, 50));
                            transactionsTable.Controls.Add(FormHelpers.AddTransaction(tx), 0, transactionsTable.RowStyles.Count - 3);
                        });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                StatusBar.Status = ex.Message;
            }

            paymentsTable = _payments;
            FormHelpers.Payments?.ForEach(pay =>
                {
                    paymentsTable.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, 100));
                    paymentsTable.Controls.Add(FormHelpers.AddPayment(pay), 0, paymentsTable.RowStyles.Count - 3);
                });

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
                CustomerService.DeleteCustomer(FormHelpers.CurrentUser.Id);
                LogoutButton_Click(sender, e);
            }
        }
        private void Refresh_Btn_Click(object sender, EventArgs e)
        {
            Dashboard_Load();
        }
    }
}
