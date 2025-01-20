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
    public static class Database
    {
        private static readonly NpgsqlDataSource _dataSource;

        static Database()
        {
            NpgsqlDataSourceBuilder builder = new NpgsqlDataSourceBuilder(ConfigurationManager.ConnectionStrings["BankingDatabaseConnectionString"].ToString());

            builder.MapEnum<Rolet>();

            _dataSource = builder.Build();
        }

        public static NpgsqlDataSource GetDataSource() => _dataSource;
    }
}
