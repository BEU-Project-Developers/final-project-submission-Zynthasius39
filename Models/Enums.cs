using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models.Enums
{
    public enum Accountt
    {
        Savings,
        Credit,
        Debit,
        Investing
    }

    public enum Rolet
    {
        Visitor,
        Member,
        Business,
        Enterprise,
        Mod,
        Admin
    }

    public enum Contractt
    {
        Mortgage,
        Loan
    }

    public enum Currency
    {
        USD,
        AZN,
        EUR,
        GOLD,
        TRY
    }

    public enum Resourcet
    {
        Cash,
        Metal,
        Share,
        Fund,
        Crypto
    }

    public enum Transactiont
    {
        Withdrawal,
        Deposit,
        Exchange
    }
}
