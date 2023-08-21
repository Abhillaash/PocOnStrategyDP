using System;
using System.Collections.Generic;
using System.Text;

namespace PocOnStrategyDP.Model
{
    class PayTMPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing paytm payment of ${amount}");
            // Logic for credit card payment
        }
    }
}
