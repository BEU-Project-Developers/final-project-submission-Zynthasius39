using BankingApp.DAL;
using BankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.BLL
{
    public static class CustomerService
    {
        public static Customer GetCustomer(int id)
        {
            return CustomerRepository.Get(id);
        }
        public static Customer GetCustomer(string email)
        {
            return CustomerRepository.Get(email);
        }

        public static int CreateCustomer(Customer customer)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(customer.Password);
            byte[] inputHash = SHA256.HashData(inputBytes);
            customer.Password = Convert.ToHexString(inputHash);

            return CustomerRepository.Add(customer);
        }

        public static void DeleteCustomer(int id)
        {
            CustomerRepository.Delete(id);
        }

        public static bool VerifyPassword(Customer customer, string password)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            byte[] inputHash = SHA256.HashData(inputBytes);

            if (customer.Password.ToUpper() == Convert.ToHexString(inputHash).ToUpper())
                return true;
            return false;
        }
    }
}
