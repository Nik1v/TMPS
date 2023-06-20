public class CreditCardPaymentStrategy : IPaymentStrategy
{
    private string cardNumber;
    private string expirationDate;
    private string cvv;

    public CreditCardPaymentStrategy(string cardNumber, string expirationDate, string cvv)
    {
        this.cardNumber = cardNumber;
        this.expirationDate = expirationDate;
        this.cvv = cvv;
    }

    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing credit card payment of amount $" + amount);
        // Logica specifică pentru procesarea plății cu cardul de credit
    }
}