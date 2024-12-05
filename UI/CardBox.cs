using MaterialSkin.Controls;

namespace BankingApp.UI
{
    public partial class CardBox : MaterialForm
    {
        public CardBox()
        {
            InitializeComponent();
            cardBack.Region = new Region(FormHelpers.CreateRoundedRectanglePath(cardBack.ClientRectangle, 30));
        }
    }
}
