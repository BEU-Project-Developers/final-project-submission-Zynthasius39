using BankingApp.BLL;
using BankingApp.Models;
using MaterialSkin.Controls;
using System.Diagnostics;

namespace BankingApp.UI
{
    public partial class CardBox : MaterialForm
    {
        private Account _account;
        public CardBox(Account account)
        {
            _account = account;

            InitializeComponent();
            cardBack.Image = new Bitmap(FormHelpers.PATH + @"\card_back.png");
            cardBack.Region = new Region(FormHelpers.CreateRoundedRectanglePath(cardBack.ClientRectangle, 30));
            expLabel.Text = _account.ExpirationDate.ToString("MM / yy");
            cvvLabel.Text = _account.CVV.ToString();
        }

        private void Reissue_btn_Click(object sender, EventArgs e)
        {
            try
            {
                _account.AccountNumber = Convert.ToInt64(FormHelpers.RandomAccountNumberGenerator());
                AccountService.ReissueAccount(_account);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                StatusBar.Status = "Failed to reissue the account!";
            }
        }
    }
}
