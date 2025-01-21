using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public class Preference
    {
        /// <summary>
        /// Preference Model
        /// 
        /// Playing entity role
        /// </summary>
        public required int Id { get; set; }

        public List<KeyValuePair<string, string>> Settings { get; set; } = [];

        public string Get(string key)
        {
            return Settings.Find(x => x.Key == key).Value;
        }

        public void Add(string key, string value)
        {
            Settings.Add(new KeyValuePair<string, string>(key, value));
        }

        public void Remove(string key)
        {
            Settings.RemoveAll(kvp => kvp.Key == key);
        }

        public void Update(string key, string value)
        {
            Settings.ForEach(kvp =>
            {
                if (kvp.Value == key)
                {
                    kvp = new KeyValuePair<string, string>(key, value);
                }
            });
        }

        public override string ToString() => String.Format(format: """
            # Preference
            #   ID: {0}
            #   Settings: {1}
            """, Id, string.Join(", ", Settings));
    }
}
