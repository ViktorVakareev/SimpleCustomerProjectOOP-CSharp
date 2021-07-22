using ACM.BL;
using NUnit.Framework;

namespace ACM.BL_Test
{
    class ProductRepositoryTests
    {
        [OneTimeSetUp]
        public void Setup()
        {
        }

        [Test]
        public void RetrieveValidProduct()
        {
            var productRepository = new ProductRepository();
            var product = new Product(123)
            {
                ProductDescription = "Assorted set of 4 mini yellow Sunflowers",
                ProductName = "Sunflowers",
                CurrentPrice = 15.96
            };

            var actualProduct = productRepository.Retrieve(123);

            Assert.AreEqual(product.ProductId, actualProduct.ProductId);
            Assert.AreEqual(product.ProductDescription, actualProduct.ProductDescription);
            Assert.AreEqual(product.ProductName, actualProduct.ProductName);
            Assert.AreEqual(product.CurrentPrice, actualProduct.CurrentPrice);

        }
        [Test]
        public void TestValidSaveOperation()
        {
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(123)
            {
                ProductDescription = "Assorted set of 4 mini yellow Sunflowers",
                ProductName = "Sunflowers",
                CurrentPrice = 17.96,
                HasChanges = true
            };

            var actualProduct = productRepository.Save(updatedProduct);

            Assert.IsTrue(actualProduct);
        }

        [Test]
        public void TestInvalidSaveOperation_MissingPrice()
        {
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(123)
            {
                ProductDescription = "Assorted set of 4 mini yellow Sunflowers",
                ProductName = "Sunflowers",
                CurrentPrice = null,   // Validate() should catch this, so it won't save the product
                HasChanges = true
            };

            var actualProduct = productRepository.Save(updatedProduct);

            Assert.IsFalse(actualProduct);
        }
    }
}
