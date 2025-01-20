using BankingApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
    public class Resource
    {
        public required int Id { get; set; }
        public required Resourcet ResourseType { get; set; }
        public required Currency Currency { get; set; }
        public required decimal Amount { get; set; }
        public override string ToString() => String.Format(format: """
            [---------------------------Customer-----]
                ID: {0}
                Name: {1}
                Destination: {2}
                Amount: {3:N2}
            [----------------------------------------]
            """, Id, ResourseType, Currency, Amount);
    }
}
