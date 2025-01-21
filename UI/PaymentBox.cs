using BankingApp.BLL;
using BankingApp.Models;
using BankingApp.Models.Enums;
using MaterialSkin.Controls;

namespace BankingApp.UI
{
    public partial class PaymentBox : MaterialForm
    {
        private Payment _payment;
        public PaymentBox(Payment payment)
        {
            _payment = payment;
            InitializeComponent();
            BackColor = AppSkinHelper.msm.BackdropColor;
            ForeColor = AppSkinHelper.msm.ColorScheme.TextColor;

            payBtn.Text = $"{_payment.Currency.ToDescription()}{_payment.Amount.ToString()}";
            paymentLabel.Text = $"{_payment.Name}\n\nTo Account\n{_payment.Destination.ToString()}";

            mainTips.SetToolTip(payBtn, "Click to Pay");
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (FormHelpers.UserDefAccount != null)
            {
                if (FormHelpers.UserDefAccount.Amount >= _payment.Amount)
                {
                    FormHelpers.UserDefAccount.Amount -= _payment.Amount;
                    AccountService.UpdateAccount(FormHelpers.UserDefAccount);
                    StatusBar.Status = "Payment completed!";
                }
                else
                {
                    StatusBar.Status = "Insufficient Balance";
                }
            }
            Close();
        }

        private void MainTips_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
