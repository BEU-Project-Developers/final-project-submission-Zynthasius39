using BankingApp.Models.Enums;

namespace BankingApp.Models
{
    public class Contract
    {
        public required int Id { get; set; }
        public required int CId { get; set; }
        public required Contractt ContractType {  get; set; }
        public required Currency Currency { get; set; }
        public required DateTime CreationDate { get; set; }
        public required DateTime ExpirationDate { get; set; }
        public required decimal Amount { get; set; }
        public override string ToString() => String.Format(format: """
            [---------------------------Contract----]
                ID: {0}
                Currency: {1}
                Type: {2}
                Creation Date: {3}
                Expiration Date: {4}
                Amount: {5:N2}
                Customer ID: {6}
            [----------------------------------------]
            """, Id, Currency, ContractType, CreationDate, ExpirationDate, Amount, CId);
    }
}
