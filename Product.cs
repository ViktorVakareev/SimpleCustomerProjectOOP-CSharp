using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Product: EntityBase
    {
        public Product()
        {
        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }
        public double? CurrentPrice { get; set; }   // Nullable type - like double->Double in Java

        public override string ToString()
        {
            return ProductName;
        }
        public override bool Validate()
        {
            bool isValid = true;
            if ((CurrentPrice == null) || (ProductId <= 0))
            {
                isValid = false;
            }
            return isValid;
        }
       
    }
}
