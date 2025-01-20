using BankingApp.Models;
using BankingApp.Models.Enums;
using Npgsql;
using System.Diagnostics;


namespace BankingApp.DAL
{
    public static class ContractRepository
    {
        public static List<Contract> GetAll()
        {
            try
            {
                List<Contract> Contracts = [];

                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("SELECT contid, cid, ctype, currency, expiration_date, creation_date, amount FROM contracts", conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Contracts.Add(new Contract
                    {
                        Id = reader.GetInt32(0),
                        CId = reader.GetInt32(1),
                        ContractType = reader.GetFieldValue<Contractt>(2),
                        Currency = reader.GetFieldValue<Currency>(3),
                        CreationDate = reader.GetFieldValue<DateTime>(4),
                        ExpirationDate = reader.GetFieldValue<DateTime>(5),
                        Amount = reader.GetDecimal(6),
                    });
                }

                return Contracts;
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static Contract Get(int id)
        {
            try
            {
                Contract? Contract = null;
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("SELECT contid, cid, ctype, currency, expiration_date, creation_date, amount WHERE contid = @id", conn);
                cmd.Parameters.AddWithValue("id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Contract = new Contract
                    {
                        Id = reader.GetInt32(0),
                        CId = reader.GetInt32(1),
                        ContractType = reader.GetFieldValue<Contractt>(2),
                        Currency = reader.GetFieldValue<Currency>(3),
                        CreationDate = reader.GetFieldValue<DateTime>(4),
                        ExpirationDate = reader.GetFieldValue<DateTime>(5),
                        Amount = reader.GetDecimal(6),
                    };
                }
                else
                {
                    Debug.WriteLine("Contract not Found");
                    throw new ContractException("Contract not Found");
                }

                return Contract;
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
                using var cmd = new NpgsqlCommand("DELETE FROM contracts WHERE contid = @id", conn);
                cmd.Parameters.AddWithValue("id", id);
                int rowsAff = cmd.ExecuteNonQuery();
                if (rowsAff > 0)
                {
                    return rowsAff;
                }
                else
                {
                    Debug.WriteLine("No Contract found to delete");
                    throw new ContractException("Contract not Found");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static int Add(Contract contract)
        {
            try
            {
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("INSERT INTO contracts (cid, ctype, currency, expiration_date, creation_date, amount) VALUES (@cid, @ctype, @currency, @expiration_date, @creation_date, @amount) RETURNING contid", conn);
                cmd.Parameters.AddWithValue("cid", contract.CId);
                cmd.Parameters.AddWithValue("ctype", contract.ContractType);
                cmd.Parameters.AddWithValue("currency", contract.Currency);
                cmd.Parameters.AddWithValue("expiration_date", contract.CreationDate);
                cmd.Parameters.AddWithValue("creation_date", contract.ExpirationDate);
                cmd.Parameters.AddWithValue("amount", contract.Amount);

                int? newId = (int?)cmd.ExecuteScalar();
                if (newId.HasValue)
                {
                    return newId.Value;
                }
                else
                {
                    Debug.WriteLine("Null New Contract ID");
                    throw new ContractException("Contract couldn't be added");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }
    }
    public class ContractException : Exception
    {
        public ContractException() { }

        public ContractException(string message) : base(message) { }
    }
}
