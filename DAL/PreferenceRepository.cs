using BankingApp.Models;
using BankingApp.Models.Enums;
using Npgsql;
using System.Diagnostics;
using System.Security.Cryptography.Xml;


namespace BankingApp.DAL
{
    public static class PreferenceRepository
    {
        /// <summary>
        /// Preference Repository
        ///     Holds UI settings to communicate
        ///     Interact, update, delete
        ///     the Database
        /// </summary>
        public static List<Preference> GetAll()
        {
            try
            {
                List<Preference> preferences = [];

                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        cid,
                        preferences
                    FROM
                        ui_preferences
                    """, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Preference preference = new()
                    {
                        Id = reader.GetInt32(0),
                    };
                    string[] settingsStrings = reader.GetFieldValue<string[]>(1);

                    foreach (string setting in settingsStrings)
                    {
                        string[] settingPair = setting.Split('=');
                        preference.Add(settingPair[0].Trim(), settingPair[1].Trim());
                    }

                    preferences.Add(preference);
                }

                return preferences;
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static Preference Get(int id)
        {
            try
            {
                Preference? preference = null;
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    SELECT
                        cid,
                        preferences
                    FROM
                        ui_preferences
                    WHERE
                        cid = @id
                    """, conn);
                cmd.Parameters.AddWithValue("id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    preference = new()
                    {
                        Id = reader.GetInt32(0),
                    };
                    string[] settingsStrings = reader.GetFieldValue<string[]>(1);

                    foreach (string setting in settingsStrings)
                    {
                        string[] settingPair = setting.Split('=');
                        preference.Add(settingPair[0].Trim(), settingPair[1].Trim());
                    }
                }
                else
                {
                    Debug.WriteLine("Preference not Found");
                    throw new PreferenceException("Preference not Found");
                }

                return preference;
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
                        ui_preferences
                    WHERE
                        cid = @id
                    """, conn);
                cmd.Parameters.AddWithValue("id", id);
                int rowsAff = cmd.ExecuteNonQuery();
                if (rowsAff > 0)
                {
                    return rowsAff;
                }
                else
                {
                    Debug.WriteLine("No Preference found to delete");
                    throw new PreferenceException("Preference not Found");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static int Add(Preference preference)
        {
            try
            {
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    INSERT INTO Preferences (
                        cid,
                        preferences
                    )
                    VALUES (
                        @cid,
                        @preferences
                    )
                    RETURNING
                        cid
                    """, conn);
                cmd.Parameters.AddWithValue("cid", preference.Id);
                cmd.Parameters.AddWithValue("preferences", preference.Settings.ToArray());

                int? newId = (int?)cmd.ExecuteScalar();
                if (newId.HasValue)
                {
                    return newId.Value;
                }
                else
                {
                    Debug.WriteLine("Null New Preference ID");
                    throw new PreferenceException("Preference couldn't be added");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
            }
        }

        public static int Update(Preference preference)
        {
            try {
                using var conn = Database.GetDataSource().OpenConnection();
                using var cmd = new NpgsqlCommand("""
                    UPDATE
                        ui_preferences 
                    SET
                        preferences = @preferences
                    WHERE
                        cid = @id
                    """, conn);
                cmd.Parameters.AddWithValue("id", preference.Id);
                cmd.Parameters.AddWithValue("preferences", preference.Settings.ToArray());
                int rowsAff = cmd.ExecuteNonQuery();
                if (rowsAff > 0)
                {
                    return rowsAff;
                }
                else
                {
                    Debug.WriteLine("No Preference found to update");
                    throw new PreferenceException("Preference not Updated");
                }
            }
            catch (NpgsqlException ex)
            {
                Debug.WriteLine(ex.Message);
                throw new DataAccessException(ex.Message);
    }
}
    }
    public class PreferenceException : Exception
    {
        public PreferenceException() { }

        public PreferenceException(string message) : base(message) { }
    }
}
