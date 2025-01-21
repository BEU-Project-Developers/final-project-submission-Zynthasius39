using BankingApp.DAL;
using BankingApp.Models;


namespace BankingApp.BLL
{
    public static class PaymentService
    {
        /// <summary>
        /// Payment Service
        ///     Used to connect UI with Repositories
        ///     More understanable code userspace
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static Payment GetPayment(int id)
        {
            try
            {
                return PaymentRepository.Get(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Faield to connect to Database");
            }
        }

        public static List<Payment> GetAllPayments()
        {
            try
            {
                return PaymentRepository.GetAll();
            }
            catch (DataAccessException)
            {
                throw new Exception("Faield to connect to Database");
            }
        }

        public static int CreatePayment(Payment payment)
        {
            try
            {
                return PaymentRepository.Add(payment);
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
                PaymentRepository.Delete(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }
    }
}
