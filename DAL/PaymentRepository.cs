using BankingApp.Models;
using BankingApp.Models.Enums;
using BankingApp.UI;
using Npgsql;
using System.Diagnostics;


namespace BankingApp.DAL
{
    public static class PaymentRepository
    {
        public static List<Payment> GetAll()
        {
            try
            {
                List<Payment> Payments = [];

                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        id,
                        name,
                        destination,
                        amount,
                        currency,
                        img_path
                    FROM
                        Payments
                    """, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Payment payment = new()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Destination = reader.GetInt64(2),
                        Amount = reader.GetDecimal(3),
                        Currency = reader.GetFieldValue<Currency>(4),
                    };
                    string imgPath = reader.GetString(5);
    
                    try
                    {
                        payment.Image = new Bitmap(FormHelpers.PATH + $@"\PaymentAssets\{imgPath}.png");
                    }
                    catch (Exception)
                    {
                        Debug.WriteLine($"{imgPath}.png couldn't be found under Assets directory");
                    }

                    Payments.Add(payment);
                }

                return Payments;
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static Payment Get(int id)
        {
            try
            {
                Payment? payment = null;
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        id,
                        name,
                        destination,
                        amount,
                        currency,
                        img_path
                    FROM
                        Payments
                    WHERE
                        id = @id
                    """, conn);
                cmd.Parameters.AddWithValue("id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    payment = new Payment
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Destination = reader.GetInt64(2),
                        Amount = reader.GetDecimal(3),
                        Currency = reader.GetFieldValue<Currency>(4),
                    };

                    string imgPath = reader.GetString(5);
    
                    try
                    {
                        payment.Image = new Bitmap(FormHelpers.PATH + $@"\PaymentAssets\{imgPath}.png");
                    }
                    catch (Exception)
                    {
                        Debug.WriteLine($"{imgPath}.png couldn't be found under Assets directory");
                    }
                }
                else
                {
                    Debug.Write("Payment not Found");
                    throw new PaymentException("Payment not Found");
                }

                return payment;
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static int Delete(int id)
        {
            try
            {
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    DELETE FROM
                        Payments
                    WHERE
                        id = @id
                    """, conn);
                cmd.Parameters.AddWithValue("id", id);
                int rowsAff = cmd.ExecuteNonQuery();
                if (rowsAff > 0)
                {
                    return rowsAff;
                }
                else
                {
                    Debug.WriteLine("No payment found to delete");
                    throw new PaymentException("Payment not Found");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static int Add(Payment payment)
        {
            try
            {
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    INSERT INTO Payments (
                        name,
                        destination,
                        amount,
                        currency,
                    )
                    VALUES (
                        @name,
                        @destination,
                        @amount,
                    )
                    RETURNING
                        cid
                    """, conn);
                cmd.Parameters.AddWithValue("name", payment.Name);
                cmd.Parameters.AddWithValue("destination", payment.Destination);
                cmd.Parameters.AddWithValue("amount", payment.Amount);
                cmd.Parameters.AddWithValue("currency", payment.Currency);

                int? newId = (int?)cmd.ExecuteScalar();
                if (newId.HasValue)
                {
                    return newId.Value;
                }
                else
                {
                    Debug.WriteLine("Null new Payment ID");
                    throw new PaymentException("Payment couldn't be added");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }
    }

    public class PaymentException : Exception
    {
        public PaymentException() { }

        public PaymentException(string message) : base(message) { }
    }
}
