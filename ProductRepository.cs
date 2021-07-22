using System;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            // code that retrieves the defined user

            // temp hard-coded values to return a product
            if (productId == 123)
            {
                product.ProductDescription = "Assorted set of 4 mini yellow Sunflowers";
                product.ProductName = "Sunflowers";
                product.CurrentPrice = 15.96;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }

        public bool Save(Product product)
        {
            bool success = true;
            if (product.HasChanges)
            {
                if (product.isValid)
                {
                    if (product.IsNew)
                    {
                        //call an Insert Stored procedure
                    }
                    else
                    {
                        //call an Update Stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
