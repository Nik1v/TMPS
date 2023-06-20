public class PaymentProcessor
{
    public void ProcessPayment(double amount, IPaymentStrategy paymentStrategy)
    {
        paymentStrategy.ProcessPayment(amount);
    }
}