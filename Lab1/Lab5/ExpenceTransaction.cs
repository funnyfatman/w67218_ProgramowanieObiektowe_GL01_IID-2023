namespace Lab5;

public class ExpenseTransaction : Transaction
{
    public ExpenseTransaction(double amount, DateTime transactionDate) 
        : base(amount, transactionDate) { }

    public override void ProcessTransaction()
    {
        Account.TotalExpenses += Amount;
    }
}