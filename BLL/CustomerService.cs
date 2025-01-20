using BankingApp.DAL;
using BankingApp.Models;
using System.Security.Cryptography;
using System.Text;


namespace BankingApp.BLL
{
    public static class CustomerService
    {
        public static Customer GetCustomer(int id)
        {
            try
            {
                return CustomerRepository.Get(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
            catch (CustomerException)
            {
                throw new Exception("Invalid E-Mail or Password");
            }
        }

        public static Customer GetCustomer(string email)
        {
            try
            {
                return CustomerRepository.Get(email);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
            catch (CustomerException)
            {
                throw new Exception("Wrong E-Mail or Password");
            }
        }

        public static int CreateCustomer(Customer customer)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(customer.Password);
            byte[] inputHash = SHA256.HashData(inputBytes);
            customer.Password = Convert.ToHexString(inputHash);

            try
            {
                return CustomerRepository.Add(customer);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static void DeleteCustomer(int id)
        {
            try {
                CustomerRepository.Delete(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static bool VerifyPassword(Customer customer, string password)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            byte[] inputHash = SHA256.HashData(inputBytes);

            if (customer.Password.Equals(Convert.ToHexString(inputHash), StringComparison.CurrentCultureIgnoreCase))
                return true;
            return false;
        }
    }
}
