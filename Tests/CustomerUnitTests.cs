using ACM.BL;
using NUnit.Framework;

namespace ACM.BL_Test
{
    [TestFixture]
    public class CustomerUnitTests

    {
        [OneTimeSetUp]
        public void Setup()
        {

        }

        // Testing properties
        [Test]
        public void FullNameTestValid()
        {
            var customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";

            Assert.AreEqual(expected, customer.FullName);
        }
        [Test]
        public void FullNameTestEmtyFirstName()
        {
            var customer = new Customer();
            customer.LastName = "Baggins";

            string expected = "Baggins";

            Assert.AreEqual(expected, customer.FullName);

        }
        [Test]
        public void FullNameTestEmtyLastName()
        {
            var customer = new Customer();
            customer.FirstName = "Bilbo";

            string expected = "Bilbo";

            Assert.AreEqual(expected, customer.FullName);
        }

        [Test]
        public void StaticMemberTest()
        {
            var customer1 = new Customer();
            customer1.FirstName = "Bilbo";
            Customer.InstanceCount++;

            var customer2 = new Customer();
            customer2.FirstName = "Frodo";
            Customer.InstanceCount++;

            var customer3 = new Customer();
            customer3.FirstName = "Rose";
            Customer.InstanceCount++;


            Assert.AreEqual(3, Customer.InstanceCount);
        }

        // Testing Methods
        [Test]
        public void ValidateValidCustomer()
        {
            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.Email = "bbaggins@gmail.com";           

            Assert.IsTrue(customer.Validate());
        }
        [Test]
        public void ValidateInvalidCustomerMissingEmail()
        {
            var customer = new Customer();
            customer.LastName = "Baggins";            

            Assert.IsFalse(customer.Validate());
        }
    }
}