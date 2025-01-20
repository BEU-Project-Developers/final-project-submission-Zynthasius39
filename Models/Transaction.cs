using BankingApp.Models.Enums;

namespace BankingApp.Models
{
    public class Transaction
    {
        public required int Id { get; set; }
        public required Transactiont TransactionType { get; set; }
        public required Currency Currency { get; set; }
        public required DateTime Date { get; set; }
        public required decimal Amount { get; set; }
    }
}
