using BankingApp.BLL;
using BankingApp.Models;
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
    public partial class Transfer : UserControl
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long srcNum = Convert.ToInt64(srcText.Text.Trim());
                long dstNum = Convert.ToInt64(destText.Text.Trim());
                decimal amount = Convert.ToDecimal(amountBox.Text.Trim());
                if (FormHelpers.UserAccounts != null && FormHelpers.CurrentUser != null)
                {
                    Account account = AccountService.GetAccountByAccNum(dstNum);
                    Account accountSrc = AccountService.GetAccountByAccNum(srcNum);
                    if (accountSrc.CIdList.Contains(FormHelpers.CurrentUser.Id))
                    {
                        if (accountSrc.Amount >= amount)
                        {
                            account.Amount += amount;
                            accountSrc.Amount -= amount;
                            AccountService.UpdateAccount(account);
                            AccountService.UpdateAccount(accountSrc);
                            StatusBar.Status = "Transfer Complete!";
                        }
                        else
                        {
                            StatusBar.Status = "Insufficient Balance";
                        }
                    } else
                    {
                        StatusBar.Status = "Not your Account";
                    }
                }
            } catch (Exception ex)
            {
                StatusBar.Status = ex.Message;
            }
        }
    }
}
