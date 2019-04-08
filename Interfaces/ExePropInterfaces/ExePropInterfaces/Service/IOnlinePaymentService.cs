using System;
using System.Collections.Generic;
using System.Text;

namespace ExePropInterfaces.Service
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);

    }
}
