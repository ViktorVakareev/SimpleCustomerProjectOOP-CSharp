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

            return product;
        }
        public bool Save()
        {
            //TODO save the passed in product
            return true;
        }
    }
}
