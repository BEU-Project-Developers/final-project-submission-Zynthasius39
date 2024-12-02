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
        public required int Id { get; set; }
        public required int[] CIdList { get; set; } = [];
        public required Accountt AccountType { get; set; }
        public required Currency Currency {  get; set; }
        public required DateTime CreationDate { get; set; }
        public required DateTime ExpirationDate { get; set; }
        public required decimal Amount { get; set; }
        public required long AccountNumber { get; set; }
    }
}
