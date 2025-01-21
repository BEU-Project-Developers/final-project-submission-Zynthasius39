namespace BankingApp.Models.Enums
{
    /// <summary>
    /// Enums
    /// 
    /// Playing entity role
    /// </summary>
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

    public static class EnumExt
    {
        public static string ToDescription(this Currency value)
            {
            if (value == Currency.USD) return "$";
            else if (value == Currency.GOLD) return "G";
            else if (value == Currency.AZN) return "₼";
            else if (value == Currency.EUR) return "€";
            else if (value == Currency.TRY) return "₺";
            else return "?";
            }
    }
}
