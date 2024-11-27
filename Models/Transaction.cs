using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string TransactionType { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}
