using BankingApp.DAL;
using BankingApp.Models;
using System.Security.Cryptography;
using System.Text;


namespace BankingApp.BLL
{
    public static class PreferenceService
    {
        public static Preference GetPreference(int id)
        {
            try
            {
                return PreferenceRepository.Get(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }
        public static int CreatePreference(Preference preference)
        {
            try
            {
                return PreferenceRepository.Add(preference);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static void DeletePreference(int id)
        {
            try
            {
                PreferenceRepository.Delete(id);
            }
            catch (DataAccessException)
            {
                throw new Exception("Failed to connect to Database");
            }
        }

        public static void UpdatePreference(Preference preference)
        {
            try
            {
                PreferenceRepository.Update(preference);
            }
            catch (DataAccessException)
            {
                throw new Exception("Faield to connect to Database");
            }
        }
    }
}
