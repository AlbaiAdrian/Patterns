// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, Strategy!");


var paymentHandler = new PaymentHandler(new CreditCardPayment());
paymentHandler.ProcessPayment(150.00m);

paymentHandler.SetStrategy(new PayPalPayment());
paymentHandler.ProcessPayment(75.50m);