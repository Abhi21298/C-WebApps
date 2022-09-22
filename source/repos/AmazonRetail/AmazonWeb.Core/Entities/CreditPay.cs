using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonWeb.Core.Entities
{
    public class CreditPay : IPayment
    {
        private string AccName;
        private long CardNumber;
        private int ExpiryMonth;
        private int ExpiryYear;
        private int CVV;
        public void GetDetails()
        {
            
        }
    }
}
