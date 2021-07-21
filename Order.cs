using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {                
        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }        
        public int? OrderId { get; set; }
        public bool Validate()
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
