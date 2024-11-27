using BankingApp.Models;
using BankingApp.Models.Enums;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankingApp.DAL
{
    public static class AccountRepository
    {
        public static List<Account> GetAll()
        {
            List<Account> Accounts = [];

            using var conn = Database.GetDataSource().OpenConnection();
            using var cmd = new NpgsqlCommand("SELECT accid, acctype, cids, currency, expiration_date, creation_date, amount FROM Accounts", conn);
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
                    Amount = reader.GetFieldValue<Decimal>(6)
                });
            }

            return Accounts;
        }

        public static Account Get(int id)
        {
            Account? Account = null;

            try
            {
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("SELECT accid, acctype, cids, currency, expiration_date, creation_date, amount FROM Accounts WHERE accid = @id", conn);
                cmd.Parameters.AddWithValue("id", id);
                using var reader = cmd.ExecuteReader();
                reader.Read();
                Account = new Account
                {
                    Id = reader.GetInt32(0),
                    AccountType = reader.GetFieldValue<Accountt>(1),
                    CIdList = reader.GetFieldValue<int[]>(2),
                    Currency = reader.GetFieldValue<Currency>(3),
                    ExpirationDate = reader.GetFieldValue<DateTime>(4),
                    CreationDate = reader.GetFieldValue<DateTime>(5),
                    Amount = reader.GetFieldValue<Decimal>(6)
                };
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            if (Account == null)
            {
                throw new Exception("Account Not Found");
            }

            return Account;
        }

        public static int Delete(int id)
        {
            using var conn = Database.GetDataSource().OpenConnection();
            using var cmd = new NpgsqlCommand("DELETE FROM Accounts WHERE accid = @id", conn);
            cmd.Parameters.AddWithValue("id", id);
            return cmd.ExecuteNonQuery();
        }

        public static int Add(Account account)
        {
            using var conn = Database.GetDataSource().OpenConnection();
            using var cmd = new NpgsqlCommand("INSERT INTO Accounts (acctype, cids, currency, expiration_date, creation_date, amount) VALUES (@acctype, @cids, @currency, @expiration_date, @creation_date, @amount) RETURNING cid", conn);
            cmd.Parameters.AddWithValue("acctype", account.AccountType);
            cmd.Parameters.AddWithValue("cids", account.CIdList);
            cmd.Parameters.AddWithValue("currency", account.Currency);
            cmd.Parameters.AddWithValue("expiration_date", account.ExpirationDate);
            cmd.Parameters.AddWithValue("creation_date", account.CreationDate);
            cmd.Parameters.AddWithValue("amount", account.Amount);

            int? newId = (int?)cmd.ExecuteScalar();
            if (newId.HasValue)
            {
                return newId.Value;
            }
            else
            {
                throw new Exception("Account couldn't be added");
            }
        }
    }
}
