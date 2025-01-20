using BankingApp.Models;
using BankingApp.Models.Enums;
using Npgsql;
using System.Diagnostics;


namespace BankingApp.DAL
{
    public static class CustomerRepository
    {
        public static List<Customer> GetAll()
        {
            try
            {
                List<Customer> customers = [];

                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        cid,
                        name,
                        surname,
                        email,
                        phone,
                        password,
                        role,
                        tids,
                        register_date
                    FROM
                        customers
                    """, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customers.Add(new Customer
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Email = reader.GetString(3),
                        Phone = reader.GetString(4),
                        Password = reader.GetString(5),
                        Role = reader.GetFieldValue<Rolet>(6),
                        TransactionIDs = reader.GetFieldValue<int[]>(7),
                        RegisterDate = reader.GetFieldValue<DateTime>(8),
                    });
                }

                return customers;
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static Customer Get(int id)
        {
            try
            {
                Customer? customer = null;
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        cid,
                        name,
                        surname,
                        email,
                        phone,
                        password,
                        role,
                        tids,
                        register_date
                    FROM
                        customers
                    WHERE
                        cid = @id
                    """, conn);
                cmd.Parameters.AddWithValue("id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    customer = new Customer
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Email = reader.GetString(3),
                        Phone = reader.GetString(4),
                        Password = reader.GetString(5),
                        Role = reader.GetFieldValue<Rolet>(6),
                        TransactionIDs = reader.GetFieldValue<int[]>(7),
                        RegisterDate = reader.GetFieldValue<DateTime>(8),
                    };
                }
                else
                {
                    Debug.WriteLine("Customer not Found");
                    throw new CustomerException("Customer not Found");
                }

                return customer;
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static Customer Get(string email)
        {
            try
            {
                Customer? customer = null;
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        cid,
                        name,
                        surname,
                        email,
                        phone,
                        password,
                        role,
                        tids,
                        register_date
                    FROM
                        customers
                    WHERE
                        email = @email
                    """, conn);
                cmd.Parameters.AddWithValue("email", email);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    customer = new Customer
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Surname = reader.GetString(2),
                        Email = reader.GetString(3),
                        Phone = reader.GetString(4),
                        Password = reader.GetString(5),
                        Role = reader.GetFieldValue<Rolet>(6),
                        TransactionIDs = reader.GetFieldValue<int[]>(7),
                        RegisterDate = reader.GetFieldValue<DateTime>(8),
                    };
                }
                else
                {
                    Debug.WriteLine("Customer not Found");
                    throw new CustomerException("Customer not Found");
                }

                return customer;
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
                        Customers
                    WHERE
                        cid = @id
                    """, conn);
                cmd.Parameters.AddWithValue("id", id);
                int rowsAff =  cmd.ExecuteNonQuery();
                if (rowsAff > 0)
                {
                    return rowsAff;
                }
                else
                {
                    Debug.WriteLine("No customer found to delete");
                    throw new CustomerException("Customer not Found");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static int Add(Customer customer)
        {
            try
            {
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    INSERT INTO Customers (
                        name,
                        surname,
                        email,
                        phone,
                        password,
                        role,
                        tids,
                        register_date
                    )
                    VALUES (
                        @name,
                        @surname,
                        @email,
                        @phone,
                        @password,
                        @role,
                        @tids,
                        @register_date
                    )
                    RETURNING
                        cid
                    """, conn);
                cmd.Parameters.AddWithValue("name", customer.Name);
                cmd.Parameters.AddWithValue("surname", customer.Surname);
                cmd.Parameters.AddWithValue("email", customer.Email);
                cmd.Parameters.AddWithValue("phone", customer.Phone);
                cmd.Parameters.AddWithValue("password", customer.Password);
                cmd.Parameters.AddWithValue("role", customer.Role);
                cmd.Parameters.AddWithValue("tids", customer.TransactionIDs);
                cmd.Parameters.AddWithValue("register_date", customer.RegisterDate);

                int? newId = (int?)cmd.ExecuteScalar();
                if (newId.HasValue)
                {
                    return newId.Value;
                }
                else
                {
                    Debug.WriteLine("Null New Customer ID");
                    throw new CustomerException("Customer couldn't be added");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }
    }
    public class CustomerException : Exception
    {
        public CustomerException() { }

        public CustomerException(string message) : base(message) { }
    }
}
