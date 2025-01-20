using BankingApp.UI;
using MaterialSkin.Controls;


namespace BankingApp
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            Hide();
            Dashboard dashboard = new();
            dashboard.Show();
        }
    }
}
