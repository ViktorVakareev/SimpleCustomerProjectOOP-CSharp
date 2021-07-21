using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);

            // code that retrieves the defined user

            // temp hard-coded values to return a product
            if (orderId == 1234)
            {                
               order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 7,21,17,11,34,                    
                  new TimeSpan(7, 0, 0));
            }

            return order;
        }
        public bool Save(Order order)
        {
            //TODO save the passed in product
            return true;
        }
    }
}
