namespace Lab5;

public abstract class Transaction
{
    public double Amount { get; set; }
    public DateTime   TransactionDate { get; set; }
    protected Transaction(double amount, DateTime transactionDate)
    {
        Amount = amount;
        TransactionDate = transactionDate;
    }

    // Abstrakcyjna metoda ProcessTransaction
    public abstract void ProcessTransaction();
}