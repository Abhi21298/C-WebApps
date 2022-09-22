using AmazonWeb.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonWeb.Core.Entities
{
    public class Order : Entity
    {
        public string UserName { get; set; }
        public PaymentMethod Payment { get; set; }
        public OrderStatus Status { get; set; }
        public decimal GrandTotal { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public class Address
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string EmailAddress { get; set; }
            public string PhoneNo { get; set; }
            public string AddressLine1 { get; set; }
            public string AddressLine2 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
            public string PinCode { get; set; }
        }
        public enum OrderStatus
        {
            Progress = 1,
            OnShipping = 2,
            Finished = 3
        };
        public enum PaymentMethod
        {
            DebitCard = 1,
            CreditCard=2,
            UPI=3
        };
    }
}
