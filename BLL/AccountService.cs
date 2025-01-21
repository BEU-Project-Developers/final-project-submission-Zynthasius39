using BankingApp.DAL;
using BankingApp.Models;


namespace BankingApp.BLL
{
    public static class AccountService
    {
        /// <summary>
        /// Account Service
        ///     Used to connect UI with Repositories
        ///     More understanable code userspace
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        public static void DeleteAccount(int id)
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

        public static void UpdateAccount(Account newAccount)
        {
            try
            {
                AccountRepository.Update(newAccount.Id, newAccount);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static void ReissueAccount(Account account)
        {
            try
            {
                AccountRepository.Update(account.Id, account);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }
    }
}
