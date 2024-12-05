using MaterialSkin.Controls;

namespace BankingApp.UI
{
    public partial class QuickBox : MaterialForm
    {
        public QuickBox(Control box)
        {
            InitializeComponent();
            BackColor = AppSkinHelper.msm.BackdropColor;
            ForeColor = AppSkinHelper.msm.ColorScheme.TextColor;
            box.Dock = DockStyle.Fill;
            Controls.Add(box);
        }
    }
}
