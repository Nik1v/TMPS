public class BitcoinPaymentStrategy : IPaymentStrategy
{
    private string bitcoinAddress;

    public BitcoinPaymentStrategy(string bitcoinAddress)
    {
        this.bitcoinAddress = bitcoinAddress;
    }

    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing Bitcoin payment of amount $" + amount);
        // Logica specifică pentru procesarea plății cu Bitcoin
    }
}