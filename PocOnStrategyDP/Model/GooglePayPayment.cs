using System;
using System.Collections.Generic;
using System.Text;

namespace PocOnStrategyDP.Model
{
    class GooglePayPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing google payment of ${amount}");
            // Logic for credit card payment
        }
    }
}
