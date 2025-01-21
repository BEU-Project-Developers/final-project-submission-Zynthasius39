using BankingApp.Models.Enums;

namespace BankingApp.Models
{
    public class Transaction
    {
        /// <summary>
        /// Transaction Model
        /// 
        /// Playing entity role
        /// </summary>
        public required int Id { get; set; }
        public required Transactiont TransactionType { get; set; }
        public required Currency Currency { get; set; }
        public required DateTime Date { get; set; }
        public required decimal Amount { get; set; }
        public override string ToString() => String.Format(format: """
            [---------------------------Customer-----]
                ID: {0}
                Type: {1}
                Currency: {2}
                Date: {3}
                Amount: {4:N2}
            [----------------------------------------]
            """, Id, TransactionType, Currency, Date, Amount);
    }
}
