using BankingApp.DAL;
using BankingApp.Models;
using BankingApp.Models.Enums;
using System.Security.Cryptography;
using System.Text;


namespace BankingApp.BLL
{
    public static class ContractService
    {
        /// <summary>
        /// Contract Service
        ///     Used to connect UI with Repositories
        ///     More understanable code userspace
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
        public static List<Contract> GetContractsByType(int id, Contractt contract_type)
        {
            try
            {
                return ContractRepository.GetAll(id, contract_type);
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
