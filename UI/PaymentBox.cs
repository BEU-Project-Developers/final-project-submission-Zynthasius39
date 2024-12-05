using MaterialSkin.Controls;

namespace BankingApp.UI
{
    public partial class PaymentBox : MaterialForm
    {
        public PaymentBox()
        {
            InitializeComponent();
            BackColor = AppSkinHelper.msm.BackdropColor;
            ForeColor = AppSkinHelper.msm.ColorScheme.TextColor;

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
