namespace Lab5;

public class Account
{
    public static double TotalIncome { get; set; }
    public static double TotalExpenses { get; set; }

    private List<Transaction> transactions = new List<Transaction>();

    // Metoda do dodawania transakcji
    public void AddTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
        transaction.ProcessTransaction();
    }
}