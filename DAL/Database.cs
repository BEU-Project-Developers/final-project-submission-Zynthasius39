using BankingApp.Models;
using BankingApp.Models.Enums;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.DAL
{
    /// <summary>
    /// Shared Datasource Class
    ///     Used to share single dataSource with entire solution
    ///     to reduce traffic and connection count
    /// </summary>
    public static class Database
    {
        private static readonly NpgsqlDataSource _dataSource;

        static Database()
        {
            NpgsqlDataSourceBuilder builder = new(ConfigurationManager.ConnectionStrings["BankingDatabase"].ToString());

            builder.MapEnum<Accountt>();
            builder.MapEnum<Rolet>();
            builder.MapEnum<Contractt>();
            builder.MapEnum<Resourcet>();
            builder.MapEnum<Transactiont>();
            builder.MapEnum<Currency>();

            _dataSource = builder.Build();
        }

        public static NpgsqlDataSource GetDataSource() => _dataSource;
    }

    public class DataAccessException : Exception
    {
        public DataAccessException() : base() { }
        public DataAccessException(string message) : base(message) { }
    }
}
