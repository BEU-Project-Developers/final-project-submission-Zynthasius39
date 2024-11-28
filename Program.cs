using BankingApp.DAL;
using BankingApp.UI;
using Npgsql;

namespace BankingApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            AppSkin.Initialize();
            ApplicationConfiguration.Initialize();
            Application.Run(new Dashboard());
        }
    }
}