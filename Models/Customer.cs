using BankingApp.Models.Enums;

namespace BankingApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required string Surname { get; set; } = string.Empty;
        public required string Email { get; set; } = string.Empty;
        public required string Phone { get; set; } = string.Empty;
        public required string Password { get; set; } = string.Empty;
        public required Rolet Role { get; set; }
    }
}
