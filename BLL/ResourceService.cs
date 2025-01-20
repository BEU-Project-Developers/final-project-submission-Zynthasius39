using BankingApp.DAL;
using BankingApp.Models;
using System.Security.Cryptography;
using System.Text;


namespace BankingApp.BLL
{
    public static class ResourceService
    {
        public static Resource GetResource(int id)
        {
            try
            {
                return ResourceRepository.Get(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static int CreateResource(Resource resource)
        {
            try
            {
                return ResourceRepository.Add(resource);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static void DeleteResource(int id)
        {
            try
            {
                ResourceRepository.Delete(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }
    }
}
