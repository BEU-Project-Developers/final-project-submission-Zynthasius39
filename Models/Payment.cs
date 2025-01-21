using BankingApp.Models.Enums;

namespace BankingApp.Models
{
    public class Payment
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required long Destination { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public Image? Image { get; set; }
        public override string ToString() => String.Format(format: """
            [---------------------------Customer-----]
                ID: {0}
                Name: {1}
                Destination: {2}
                Amount: {3}
                Currency: {4}
            [----------------------------------------]
            """, Id, Name, Destination, Amount, Currency);
    }
}
