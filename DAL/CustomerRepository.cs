using BankingApp.Models;
using BankingApp.Models.Enums;
using Npgsql;
using System.Collections.Generic;
using System.Diagnostics;


namespace BankingApp.DAL
{
    public static class CustomerRepository
    {
        public static List<Customer> GetAll()
        {
            List<Customer> customers = [];

            using var conn = Database.GetDataSource().OpenConnection();
            using var cmd = new NpgsqlCommand("SELECT cid, name, surname, email, phone, password, role FROM customers", conn);
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
                });
            }

            return customers;
        }

        public static Customer Get(int id)
        {
            Customer? customer = null;

            using var conn = Database.GetDataSource().OpenConnection();
            using var cmd = new NpgsqlCommand("SELECT cid, name, surname, email, phone, password, role FROM customers WHERE cid = @id", conn);
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
                };
            }
            else
            {
                throw new Exception("Customer Not Found");
            }

            return customer;
        }

        public static Customer Get(string email)
        {
            Customer? customer = null;

            try
            {
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("SELECT cid, name, surname, email, phone, password, role FROM customers WHERE email = @email", conn);
                cmd.Parameters.AddWithValue("email", email);
                using var reader = cmd.ExecuteReader();
                reader.Read();
                customer = new Customer
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Surname = reader.GetString(2),
                    Email = reader.GetString(3),
                    Phone = reader.GetString(4),
                    Password = reader.GetString(5),
                    Role = reader.GetFieldValue<Rolet>(6),
                };
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            if (customer == null)
            {
                throw new Exception("Customer Not Found");
            }

            return customer;
        }

        public static int Delete(int id)
        {
            using var conn = Database.GetDataSource().OpenConnection();
            using var cmd = new NpgsqlCommand("DELETE FROM Customers WHERE cid = @id", conn);
            cmd.Parameters.AddWithValue("id", id);
            return cmd.ExecuteNonQuery();
        }

        public static int Add(Customer customer)
        {
            using var conn = Database.GetDataSource().OpenConnection();
            using var cmd = new NpgsqlCommand("INSERT INTO Customers (name, surname, email, phone, password, role) VALUES (@name, @surname, @email, @phone, @password, @role) RETURNING cid", conn);
            cmd.Parameters.AddWithValue("name", customer.Name);
            cmd.Parameters.AddWithValue("surname", customer.Surname);
            cmd.Parameters.AddWithValue("email", customer.Email);
            cmd.Parameters.AddWithValue("phone", customer.Phone);
            cmd.Parameters.AddWithValue("password", customer.Password);
            cmd.Parameters.AddWithValue("role", customer.Role);

            int? newId = (int?)cmd.ExecuteScalar();
            if (newId.HasValue)
            {
                return newId.Value;
            } else
            {
                throw new Exception("Customer couldn't be added");
            }
        }
    }
}
