using BankingApp.Models;
using BankingApp.Models.Enums;
using MaterialSkin.Controls;

namespace BankingApp.UI
{
    public partial class PaymentBox : MaterialForm
    {
        public PaymentBox(Payment payment)
        {
            InitializeComponent();
            BackColor = AppSkinHelper.msm.BackdropColor;
            ForeColor = AppSkinHelper.msm.ColorScheme.TextColor;

            payBtn.Text = $"{payment.Currency.ToDescription()}{payment.Amount.ToString()}";
            paymentLabel.Text = $"{payment.Name}\n\nTo Account\n{payment.Destination.ToString()}";

            mainTips.SetToolTip(payBtn, "Click to Pay");
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainTips_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
