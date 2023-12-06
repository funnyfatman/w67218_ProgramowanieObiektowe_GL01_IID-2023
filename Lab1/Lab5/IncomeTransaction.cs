namespace Lab5;

public class IncomeTransaction : Transaction
{
    public IncomeTransaction(double amount, DateTime transactionDate) 
        : base(amount, transactionDate) { }

    public override void ProcessTransaction()
    {
        Account.TotalIncome += Amount;
    }
}