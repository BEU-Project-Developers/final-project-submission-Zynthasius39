using System.Text.RegularExpressions;

namespace BankingApp.BLL
{
    static class VerifyService
    {
        /// <summary>
        /// Verify Service
        ///     Used to connect UI with Repositories
        ///     More understanable code userspace
        ///     
        /// Contains additional Customer Services
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
