using BankingApp.DAL;
using BankingApp.Models;
using System.Security.Cryptography;
using System.Text;


namespace BankingApp.BLL
{
    public static class ResourceService
    {
        /// <summary>
        /// Resource Service
        ///     Used to connect UI with Repositories
        ///     More understanable code userspace
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
