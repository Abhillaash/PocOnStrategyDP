using System;
using PocOnStrategyDP.Model;

namespace PocOnStrategyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IPaymentStrategy paymentStrategy1 = new GooglePayPayment();
            IPaymentStrategy paymentStrategy2 = new PayTMPayment();

            ChoosePayment choosePayment = new ChoosePayment(paymentStrategy1);
            choosePayment.MakePayment(100.00);

            choosePayment.SetPaymentStrategy(paymentStrategy2);
            choosePayment.MakePayment(50.00);
        }
    }
}
