namespace BankingApp.Models
{
    public class Payment
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required long Destination { get; set; }
        public decimal Amount { get; set; }
        public Image? Image { get; set; }
    }
}
