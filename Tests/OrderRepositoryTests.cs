using ACM.BL;
using NUnit.Framework;
using System;

namespace ACM.BL_Test
{
    class OrderRepositoryTests
    {
        [OneTimeSetUp]
        public void Setup()
        {
        }

        [Test]
        public void RetrieveValidOrder()
        {
            var orderRepository = new OrderRepository();
            var order = new Order(1234)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 7, 21, 17, 11, 34,
                new TimeSpan(7,0,0))

            };

            var actualOrder = orderRepository.Retrieve(1234);

            Assert.AreEqual(order.OrderDate, actualOrder.OrderDate);
        }
        [Test]
        public void TestValidSaveOperation()
        {
            var orderRepository = new OrderRepository();
            var updatedOrder = new Order(123)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 7, 21, 17, 11, 34,
                new TimeSpan(7, 0, 0)),
                HasChanges = true
            };

            var actualOrder = orderRepository.Save(updatedOrder);

            Assert.IsTrue(actualOrder);
        }

        [Test]
        public void TestInvalidSaveOperation_MissingDate()
        {
            var orderRepository = new OrderRepository();
            var updatedOrder = new Order(123)
            {
                OrderDate = null,
                HasChanges = true
            };

            var actualOrder = orderRepository.Save(updatedOrder);

            Assert.IsFalse(actualOrder);
        }
    }
}
