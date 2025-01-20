using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public List<int> CIdList { get; set; } = [];
        public string ContractType {  get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty ;
        public DateTime CreationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Amount { get; set; }
    }
}
