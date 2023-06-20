// Creăm un procesor de plăți
PaymentProcessor paymentProcessor = new PaymentProcessor();

// Efectuăm o plată cu cardul de credit
IPaymentStrategy creditCardPayment = new CreditCardPaymentStrategy("1234 5678 9012 3456", "12/2025", "123");
paymentProcessor.ProcessPayment(100.0, creditCardPayment);

// Efectuăm o plată cu PayPal
IPaymentStrategy payPalPayment = new PayPalPaymentStrategy("example@example.com", "password");
paymentProcessor.ProcessPayment(50.0, payPalPayment);

// Efectuăm o plată cu Bitcoin
IPaymentStrategy bitcoinPayment = new BitcoinPaymentStrategy("1AbCDeFgHiJkLmNoPqRsTuvWxYz");
paymentProcessor.ProcessPayment(200.0, bitcoinPayment);

Console.ReadKey();
