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
        public required int[] TransactionIDs { get; set; }
        public required DateTime RegisterDate { get; set; }

        public override string ToString() => String.Format(format: """
            [---------------------------Customer-----]
                ID: {0}
                Name: {1}
                Surname: {2}
                Email: {3}
                Phone: {4}
                Password: {5}
                Role: {6}
                Transactions: {7}
                Register Date: {8}
            [----------------------------------------]
            """, Id, Name, Surname, Email, Phone, Password, Role, string.Join(", ", TransactionIDs), RegisterDate.ToString());
    }
}
