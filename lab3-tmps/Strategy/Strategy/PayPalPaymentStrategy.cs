public class PayPalPaymentStrategy : IPaymentStrategy
{
    private string email;
    private string password;

    public PayPalPaymentStrategy(string email, string password)
    {
        this.email = email;
        this.password = password;
    }

    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing PayPal payment of amount $" + amount);
        // Logica specifică pentru procesarea plății cu PayPal
    }
}