using BankingApp.Models;
using BankingApp.Models.Enums;
using Npgsql;
using System.Diagnostics;


namespace BankingApp.DAL
{
    public static class AccountRepository
    {
        public static List<Account> GetAll()
        {
            try
            {
                List<Account> Accounts = [];

                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        accid,
                        acctype,
                        cids,
                        currency,
                        expiration_date,
                        creation_date,
                        amount,
                        accnumber,
                        cvv
                    FROM
                        Accounts
                    """, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Accounts.Add(new Account
                    {
                        Id = reader.GetInt32(0),
                        AccountType = reader.GetFieldValue<Accountt>(1),
                        CIdList = reader.GetFieldValue<int[]>(2),
                        Currency = reader.GetFieldValue<Currency>(3),
                        ExpirationDate = reader.GetFieldValue<DateTime>(4),
                        CreationDate = reader.GetFieldValue<DateTime>(5),
                        Amount = reader.GetDecimal(6),
                        AccountNumber = reader.GetInt64(7),
                        CVV = reader.GetInt32(8),
                    });
                }

                return Accounts;
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static Account Get(int id)
        {
            try
            {
                Account? account = null;
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        accid,
                        acctype,
                        cids,
                        currency,
                        expiration_date,
                        creation_date,
                        amount,
                        accnumber,
                        cvv
                    FROM
                        Accounts
                    WHERE
                        accid = @id
                    """, conn);
                cmd.Parameters.AddWithValue("id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    account = new Account
                    {
                        Id = reader.GetInt32(0),
                        AccountType = reader.GetFieldValue<Accountt>(1),
                        CIdList = reader.GetFieldValue<int[]>(2),
                        Currency = reader.GetFieldValue<Currency>(3),
                        ExpirationDate = reader.GetFieldValue<DateTime>(4),
                        CreationDate = reader.GetFieldValue<DateTime>(5),
                        Amount = reader.GetDecimal(6),
                        AccountNumber = reader.GetInt64(7),
                        CVV = reader.GetInt32(8),
                    };
                }
                else
                {
                    Debug.Write("Account not Found");
                    throw new AccountException("Account not Found");
                }

                return account;
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static List<Account> GetAllByCustomerId(int cid)
        {
            try
            {
                List<Account> Accounts = [];

                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        accid,
                        acctype,
                        cids,
                        currency,
                        expiration_date,
                        creation_date,
                        amount,
                        accnumber,
                        cvv
                    FROM
                        Accounts
                    WHERE
                        @cid = ANY(cids)
                    """, conn
                );
                cmd.Parameters.AddWithValue("cid", cid);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Accounts.Add(new Account
                    {
                        Id = reader.GetInt32(0),
                        AccountType = reader.GetFieldValue<Accountt>(1),
                        CIdList = reader.GetFieldValue<int[]>(2),
                        Currency = reader.GetFieldValue<Currency>(3),
                        ExpirationDate = reader.GetFieldValue<DateTime>(4),
                        CreationDate = reader.GetFieldValue<DateTime>(5),
                        Amount = reader.GetDecimal(6),
                        AccountNumber = reader.GetInt64(7),
                        CVV = reader.GetInt32(8),
                    });
                }

                return Accounts;
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static Account GetByAccNum(long accnum)
        {
            try
            {
                Account? account = null;
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        accid,
                        acctype,
                        cids,
                        currency,
                        expiration_date,
                        creation_date,
                        amount,
                        accnumber,
                        cvv
                    FROM
                        Accounts
                    WHERE
                        accnumber = @accnumber
                    """, conn);
                cmd.Parameters.AddWithValue("accnumber", accnum);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    account = new Account
                    {
                        Id = reader.GetInt32(0),
                        AccountType = reader.GetFieldValue<Accountt>(1),
                        CIdList = reader.GetFieldValue<int[]>(2),
                        Currency = reader.GetFieldValue<Currency>(3),
                        ExpirationDate = reader.GetFieldValue<DateTime>(4),
                        CreationDate = reader.GetFieldValue<DateTime>(5),
                        Amount = reader.GetDecimal(6),
                        AccountNumber = reader.GetInt64(7),
                        CVV = reader.GetInt32(8),
                    };
                }
                else
                {
                    Debug.Write("Account not Found");
                    throw new AccountException("Account not Found");
                }

                return account;
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
                        Accounts
                    WHERE
                        accid = @id
                    """, conn);
                cmd.Parameters.AddWithValue("id", id);
                int rowsAff = cmd.ExecuteNonQuery();
                if (rowsAff > 0)
                {
                    return rowsAff;
                }
                else
                {
                    Debug.WriteLine("No account found to delete");
                    throw new AccountException("Account not Found");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static int Add(Account account)
        {
            try
            {
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    INSERT INTO Accounts (
                        acctype,
                        cids,
                        currency,
                        expiration_date,
                        creation_date,
                        amount,
                        cvv
                    )
                    VALUES (
                        @acctype,
                        @cids,
                        @currency,
                        @expiration_date,
                        @creation_date,
                        @amount
                        @cvv
                    )
                    RETURNING
                        cid
                    """, conn);
                cmd.Parameters.AddWithValue("acctype", account.AccountType);
                cmd.Parameters.AddWithValue("cids", account.CIdList);
                cmd.Parameters.AddWithValue("currency", account.Currency);
                cmd.Parameters.AddWithValue("expiration_date", account.ExpirationDate);
                cmd.Parameters.AddWithValue("creation_date", account.CreationDate);
                cmd.Parameters.AddWithValue("amount", account.Amount);
                cmd.Parameters.AddWithValue("cvv", account.CVV);

                int? newId = (int?)cmd.ExecuteScalar();
                if (newId.HasValue)
                {
                    return newId.Value;
                }
                else
                {
                    Debug.WriteLine("Null new Account ID");
                    throw new AccountException("Account couldn't be added");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static void Update(int oldAccId, Account newAccount)
        {
            try
            {
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    UPDATE
                        Accounts
                    SET
                        accid = @accid,
                        acctype = @acctype,
                        cids = @cids,
                        currency = @currency,
                        expiration_date = @expr_date,
                        creation_date = @crt_date,
                        amount = @amount,
                        accnumber = @accnumber,
                        cvv = @cvv
                    WHERE
                        accid = @oldaccid
                    """, conn);
                cmd.Parameters.AddWithValue("oldaccid", oldAccId);
                cmd.Parameters.AddWithValue("accid", newAccount.Id);
                cmd.Parameters.AddWithValue("acctype", newAccount.AccountType);
                cmd.Parameters.AddWithValue("cids", newAccount.CIdList);
                cmd.Parameters.AddWithValue("currency", newAccount.Currency);
                cmd.Parameters.AddWithValue("expr_date", newAccount.ExpirationDate);
                cmd.Parameters.AddWithValue("crt_date", newAccount.CreationDate);
                cmd.Parameters.AddWithValue("amount", newAccount.Amount);
                cmd.Parameters.AddWithValue("accnumber", newAccount.AccountNumber);
                int rowsAff = cmd.ExecuteNonQuery();
                if (rowsAff <= 0)
                {
                    Debug.WriteLine("No account found to update");
                    throw new AccountException("Account not Found");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }
    }

    public class AccountException : Exception
    {
        public AccountException() { }

        public AccountException(string message) : base(message) { }
    }
}
