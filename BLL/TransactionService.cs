using BankingApp.DAL;
using BankingApp.Models;
using System.Security.Cryptography;
using System.Text;


namespace BankingApp.BLL
{
    public static class TransactionService
    {
        public static Transaction GetTransaction(int id)
        {
            try
            {
                return TransactionRepository.Get(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static int CreateTransaction(Transaction Transaction)
        {
            try
            {
                return TransactionRepository.Add(Transaction);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static void DeleteTransaction(int id)
        {
            try
            {
                TransactionRepository.Delete(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }
    }
}
