using BankingApp.Models;
using BankingApp.Models.Enums;
using Npgsql;
using System.Diagnostics;


namespace BankingApp.DAL
{
    public static class TransactionRepository
    {
        public static List<Transaction> GetAll()
        {
            try
            {
                List<Transaction> Transactions = [];

                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        tid,
                        ttype,
                        currency,
                        date,
                        amount
                    FROM
                        transactions
                    """, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Transactions.Add(new Transaction
                    {
                        Id = reader.GetInt32(0),
                        TransactionType = reader.GetFieldValue<Transactiont>(1),
                        Currency = reader.GetFieldValue<Currency>(2),
                        Date = reader.GetFieldValue<DateTime>(3),
                        Amount = reader.GetDecimal(4),
                    });
                }

                return Transactions;
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static List<Transaction> GetAllByTransactionIds(int[] tids)
        {
            try
            {
                List<Transaction> Transactions = [];

                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        tid,
                        ttype,
                        currency,
                        date,
                        amount
                    FROM
                        transactions
                    WHERE
                        tid = ANY(@tids)
                    """, conn);
                cmd.Parameters.AddWithValue("tids", tids);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Transactions.Add(new Transaction
                    {
                        Id = reader.GetInt32(0),
                        TransactionType = reader.GetFieldValue<Transactiont>(1),
                        Currency = reader.GetFieldValue<Currency>(2),
                        Date = reader.GetFieldValue<DateTime>(3),
                        Amount = reader.GetDecimal(4),
                    });
                }

                return Transactions;
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static Transaction Get(int id)
        {
            try
            {
                Transaction? Transaction = null;
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        tid,
                        ttype,
                        currency,
                        date,
                        amount
                    FROM
                        transactions
                    WHERE
                        tid = @id
                    """, conn);
                cmd.Parameters.AddWithValue("id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Transaction = new Transaction
                    {
                        Id = reader.GetInt32(0),
                        TransactionType = reader.GetFieldValue<Transactiont>(1),
                        Currency = reader.GetFieldValue<Currency>(2),
                        Date = reader.GetFieldValue<DateTime>(3),
                        Amount = reader.GetDecimal(4),
                    };
                }
                else
                {
                    Debug.WriteLine("Transaction not Found");
                    throw new TransactionException("Transaction not Found");
                }

                return Transaction;
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
                        transactions
                    WHERE
                        tid = @id
                    """, conn);
                cmd.Parameters.AddWithValue("id", id);
                int rowsAff = cmd.ExecuteNonQuery();
                if (rowsAff > 0)
                {
                    return rowsAff;
                }
                else
                {
                    Debug.WriteLine("No Transaction found to delete");
                    throw new TransactionException("Transaction not Found");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static int Add(Transaction Transaction)
        {
            try
            {
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    INSERT INTO Transactions (
                        ttype,
                        currency,
                        date,
                        amount
                    )
                    VALUES (
                        @ttype,
                        @currency,
                        @date,
                        @amount
                    )
                    RETURNING
                        tid
                    """, conn);
                cmd.Parameters.AddWithValue("ttype", Transaction.TransactionType);
                cmd.Parameters.AddWithValue("currency", Transaction.Currency);
                cmd.Parameters.AddWithValue("date", Transaction.Date);
                cmd.Parameters.AddWithValue("amount", Transaction.Amount);

                int? newId = (int?)cmd.ExecuteScalar();
                if (newId.HasValue)
                {
                    return newId.Value;
                }
                else
                {
                    Debug.WriteLine("Null New Transaction ID");
                    throw new TransactionException("Transaction couldn't be added");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }
    }
    public class TransactionException : Exception
    {
        public TransactionException() { }

        public TransactionException(string message) : base(message) { }
    }
}
