using System;
using System.Collections.Generic;
using System.Text;

namespace PocOnStrategyDP.Model
{
    class ChoosePayment
    {
        private IPaymentStrategy _paymentStrategy;

        public ChoosePayment(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void MakePayment(double amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }
    }
}
