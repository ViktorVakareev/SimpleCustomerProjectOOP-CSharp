using ACM.BL;
using CommonFunctionalityLibrary;
using NUnit.Framework;
using System.Collections.Generic;

namespace CommonFunctionalityLibrary_Tests
{
    class LoggingServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                Email = "baggins@gomail.com",
                FirstName = "Crodo",
                LastName = "Baggins",
                AddressList = null

            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Cake",
                ProductDescription = "Plastic cake with decoration",
                CurrentPrice = 21.28
            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);
        }


    }
}
