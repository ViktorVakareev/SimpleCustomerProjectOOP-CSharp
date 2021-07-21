using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderItem
    {
        public int ProductId { get; set; }
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public double? PurchasePrice { get; set; }

        public bool Validate()
        {
            bool isValid = true;
            if ((PurchasePrice == null)||(Quantity <= 0)||(ProductId <= 0))
            {
                isValid = false;
            }
            return isValid;
        }

        public bool Save()
        {
            //TODO save the defined order
            return true;
        }
        public OrderItem Retrieve(int orderItemId)
        {
            // retrieves a defined orderItem
            return new OrderItem();
        }
        public List<OrderItem> Retrieve()
        {
            // retrieves all orderItems
            return new List<OrderItem>();
        }
    }
}
