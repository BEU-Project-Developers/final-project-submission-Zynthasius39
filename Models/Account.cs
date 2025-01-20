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

        public override string ToString() => String.Format(format: """
            [---------------------------Account------]
                ID: {0}
                Currency: {1}
                Creation Date: {2}
                Expiration Date: {3}
                Amount: {4:N2}
                Customers: {5}
                Num: {6}
            [----------------------------------------]
            """, Id, Currency, CreationDate, ExpirationDate, Amount, string.Join(", ", CIdList), AccountNumber);
    }
}
