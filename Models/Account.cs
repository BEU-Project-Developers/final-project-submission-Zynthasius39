using BankingApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankingApp.Models
{
    
    public class Account
    {
        public int Id { get; set; }
        public int[] CIdList { get; set; } = [];
        public Accountt AccountType { get; set; }
        public Currency Currency {  get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public decimal Amount { get; set; }
    }
}
