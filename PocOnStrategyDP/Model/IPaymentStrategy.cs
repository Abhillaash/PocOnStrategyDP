using System;
using System.Collections.Generic;
using System.Text;

namespace PocOnStrategyDP.Model
{
    interface IPaymentStrategy
    {
        void ProcessPayment(double amount);
    }
}
