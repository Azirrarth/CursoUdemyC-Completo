using System;
using System.Collections.Generic;
using System.Text;
using ExePropInterfaces.Entities;
using ExePropInterfaces.Service;

namespace ExePropInterfaces.Service
{
    class PaypalService : IOnlinePaymentService
    {

        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }

    }
}
