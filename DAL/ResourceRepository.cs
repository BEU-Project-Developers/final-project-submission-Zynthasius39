using BankingApp.Models;
using BankingApp.Models.Enums;
using Npgsql;
using System.Diagnostics;


namespace BankingApp.DAL
{
    public static class ResourceRepository
    {
        public static List<Resource> GetAll()
        {
            try
            {
                List<Resource> Resources = [];

                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("SELECT resid, restype, currency, amount FROM resources", conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Resources.Add(new Resource
                    {
                        Id = reader.GetInt32(0),
                        ResourseType = reader.GetFieldValue<Resourcet>(1),
                        Currency = reader.GetFieldValue<Currency>(2),
                        Amount = reader.GetDecimal(3),
                    });
                }

                return Resources;
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static Resource Get(int id)
        {
            try
            {
                Resource? Resource = null;
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("SELECT resid, restype, currency, amount FROM resources WHERE resid = @id", conn);
                cmd.Parameters.AddWithValue("id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Resource = new Resource
                    {
                        Id = reader.GetInt32(0),
                        ResourseType = reader.GetFieldValue<Resourcet>(1),
                        Currency = reader.GetFieldValue<Currency>(2),
                        Amount = reader.GetDecimal(3),
                    };
                }
                else
                {
                    Debug.WriteLine("Resource not Found");
                    throw new ResourceException("Resource not Found");
                }

                return Resource;
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
                using var cmd = new NpgsqlCommand("DELETE FROM resources WHERE resid = @id", conn);
                cmd.Parameters.AddWithValue("id", id);
                int rowsAff = cmd.ExecuteNonQuery();
                if (rowsAff > 0)
                {
                    return rowsAff;
                }
                else
                {
                    Debug.WriteLine("No Resource found to delete");
                    throw new ResourceException("Resource not Found");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static int Add(Resource Resource)
        {
            try
            {
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("INSERT INTO resources (restype, currency, amount) VALUES (@restype, @currency, @amount) RETURNING resid", conn);
                cmd.Parameters.AddWithValue("restype", Resource.ResourseType);
                cmd.Parameters.AddWithValue("currency", Resource.Currency);
                cmd.Parameters.AddWithValue("amount", Resource.Amount);

                int? newId = (int?)cmd.ExecuteScalar();
                if (newId.HasValue)
                {
                    return newId.Value;
                }
                else
                {
                    Debug.WriteLine("Null New Resource ID");
                    throw new ResourceException("Resource couldn't be added");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }
    }
    public class ResourceException : Exception
    {
        public ResourceException() { }

        public ResourceException(string message) : base(message) { }
    }
}
