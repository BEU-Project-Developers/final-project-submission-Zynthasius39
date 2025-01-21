using BankingApp.BLL;
using MaterialSkin.Controls;

namespace BankingApp.UI
{
    public partial class ChangePassword : MaterialForm
    {
        public ChangePassword()
        {
            InitializeComponent();
            AppSkinHelper.msm.AddFormToManage(this);
            StatusBar.AddStatusBar(chPassStatus);
        }

        private void ChPassBtn_Click(object sender, EventArgs e)
        {
            if (FormHelpers.CurrentUser != null)
            {
                // Verify trimmed password
                // Hash it using SHA256
                // Update the database accordingly
                if (CustomerService.VerifyPassword(FormHelpers.CurrentUser, curPassText.Text.Trim()))
                {
                    if (newPassText0.Text.Equals(newPassText1.Text))
                    {
                        CustomerService.ChangePassword(FormHelpers.CurrentUser, newPassText0.Text);
                        StatusBar.Status = "Password changed successfully!";
                        Close();
                    }
                    else
                        StatusBar.Status = "New passwords don't match!";
                }
                else
                    StatusBar.Status = "Wrong password!";
            }
        }
    }
}
