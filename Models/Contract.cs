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
    }
}
