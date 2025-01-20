using System.Text.RegularExpressions;

namespace BankingApp.BLL
{
    static class VerifyService
    {
        public static bool VerifyEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new(pattern);
            return regex.IsMatch(email);
        }

        public static bool ForgotPassword()
        {
            return true;
        }
    }
}
