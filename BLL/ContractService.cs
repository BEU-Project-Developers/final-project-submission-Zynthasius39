using BankingApp.DAL;
using BankingApp.Models;
using System.Security.Cryptography;
using System.Text;


namespace BankingApp.BLL
{
    public static class ContractService
    {
        public static Contract GetContract(int id)
        {
            try
            {
                return ContractRepository.Get(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static int CreateContract(Contract Contract)
        {
            try
            {
                return ContractRepository.Add(Contract);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static void DeleteContract(int id)
        {
            try
            {
                ContractRepository.Delete(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }
    }
}
