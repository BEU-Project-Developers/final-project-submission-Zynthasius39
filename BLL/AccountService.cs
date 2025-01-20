using BankingApp.DAL;
using BankingApp.Models;


namespace BankingApp.BLL
{
    public static class AccountService
    {
        public static Account GetAccount(int id)
        {
            try
            {
                return AccountRepository.Get(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Faield to connect to Database");
            }
        }

        public static List<Account> GetAccountsByCustomerId(int cid)
        {
            try
            {
                return AccountRepository.GetAllByCustomerId(cid);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static Account GetAccountByAccNum(long accNum)
        {
            try
            {
                return AccountRepository.GetByAccNum(accNum);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static int CreateAccount(Account account)
        {
            try
            {
                return AccountRepository.Add(account);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static void DeleteCustomer(int id)
        {
            try
            {
                AccountRepository.Delete(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }
    }
}
