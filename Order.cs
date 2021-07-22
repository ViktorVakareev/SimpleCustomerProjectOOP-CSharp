using System;
using System.Collections.Generic;
using CommonFunctionalityLibrary;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int? OrderId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        public string Log() =>
            $"{OrderId} Date: {this.OrderDate.Value.Date} Status: {this.entityState.ToString()}";
        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";
        public override bool Validate()
        {
            bool isValid = true;
            if ((OrderId == null) || (OrderDate == null))
            {
                isValid = false;
            }
            return isValid;
        }


    }
}
