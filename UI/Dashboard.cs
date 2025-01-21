using BankingApp.BLL;
using BankingApp.Models.Enums;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.Windows.Forms;

namespace BankingApp.UI
{
    public partial class Dashboard : MaterialForm
    {
        public Dashboard()
        {
            InitializeComponent();

            // Using custom class to store MaterialUI theme
            AppSkinHelper.msm.AddFormToManage(this);

            // Subscribing the status bar to custom statusbar manager
            StatusBar.AddStatusBar(mainStatus);

            // Load dashboard
            // Fetching from database
            Dashboard_Load();


            // Tooltips
            mainTips.SetToolTip(logoutButton0, "Logout of your account");
        }

        private void Dashboard_Load()
        {
            try
            {
                // Load Image using custom PATH
                profilePic.Image = new Bitmap(FormHelpers.PATH + @"\user.png");
                FormHelpers.Payments = PaymentService.GetAllPayments();

                if (FormHelpers.CurrentUser != null)
                {
                    // Fetch User's Accounts, Contracts, Transactions using their services respectively
                    customerName.Text = FormHelpers.CurrentUser.Name;
                    FormHelpers.UserAccounts = AccountService.GetAccountsByCustomerId(FormHelpers.CurrentUser.Id);
                    FormHelpers.UserContracts = ContractService.GetContractsByType(FormHelpers.CurrentUser.Id, Contractt.Loan);
                    FormHelpers.UserTransactions = TransactionService.GetTransactionsByCustomer(FormHelpers.CurrentUser);


                    // User info
                    customerInfo.Text = string.Format(format: """
                        Net Worth: {0} $
                        Total Debt: {1} $
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

                    // Clearing cards
                    cardsTable.RowStyles.Clear();
                    cardsTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    cardsTable.Controls.Clear();
                    accComboBox.Items.Clear();
                    // Adding cards
                    // Settings combo box
                    FormHelpers.UserAccounts.ForEach(acc =>
                        {
                            accComboBox.Items.Add(acc.AccountNumber);
                            cardsTable.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, 200));
                            cardsTable.Controls.Add(FormHelpers.AddAccount(acc), 0, cardsTable.RowStyles.Count - 3);
                        });

                    // Set default default account first one
                    if (FormHelpers.UserAccounts != null)
                        if (FormHelpers.UserAccounts.Count > 0)
                        {
                            FormHelpers.UserDefAccount = FormHelpers.UserAccounts[0];
                            accComboBox.SelectedValue = FormHelpers.UserAccounts[0].AccountNumber;
                        }

                    // Clearing transactions
                    transactionsTable.RowStyles.Clear();
                    transactionsTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    transactionsTable.Controls.Clear();
                    // Adding transactions
                    for (int i = 0; i < FormHelpers.UserTransactions.Count; i++)
                        {
                            if (i == 11) break;
                            transactionsTable.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, 50));
                            transactionsTable.Controls.Add(FormHelpers.AddTransaction(FormHelpers.UserTransactions[i]), 0, transactionsTable.RowStyles.Count - 3);
                        };
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                StatusBar.Status = ex.Message;
            }

            // Clearing payments
            paymentsTable.RowStyles.Clear();
            paymentsTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            paymentsTable.Controls.Clear();
            // Adding default payments
            // Doesn't interfere with customer itself
            FormHelpers.Payments?.ForEach(pay =>
                {
                    paymentsTable.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, 100));
                    paymentsTable.Controls.Add(FormHelpers.AddPayment(pay), 0, paymentsTable.RowStyles.Count - 3);
                });

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // Logout main event
            Hide();
            LoginForm loginForm = new();
            loginForm.FormClosed += (sender, args) => { Close(); };
            loginForm.Show();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            // Change password using a Customer Service
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            if (FormHelpers.CurrentUser != null)
            {
                // Delete account from database using a Customer Service
                CustomerService.DeleteCustomer(FormHelpers.CurrentUser.Id);
                LogoutButton_Click(sender, e);
            }
        }
        private void Refresh_Btn_Click(object sender, EventArgs e)
        {
            // Fast-Refresh
            Dashboard_Load();
        }

        private void accComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update default account
            if (FormHelpers.UserAccounts != null)
            {
                FormHelpers.UserDefAccount = FormHelpers.UserAccounts[accComboBox.SelectedIndex];
            } else
            {
                StatusBar.Status = "Couldn't set default account!";
            }
        }
    }
}
