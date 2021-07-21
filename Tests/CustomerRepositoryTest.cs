using ACM.BL;
using NUnit.Framework;
using System.Collections.Generic;

namespace ACM.BL_Test
{
    [TestFixture]
    class CustomerRepositoryTest
    {
        [OneTimeSetUp]
        public void Setup()
        {

        }

        [Test]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();
            var expectedCustomer = new Customer(1)
            {
                Email = "fbaggins@gomail.com",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            var actualCustomer = customerRepository.Retrieve(1);

            Assert.AreEqual(expectedCustomer.CustomerId, actualCustomer.CustomerId);
            Assert.AreEqual(expectedCustomer.Email, actualCustomer.Email);
            Assert.AreEqual(expectedCustomer.FirstName, actualCustomer.FirstName);
            Assert.AreEqual(expectedCustomer.LastName, actualCustomer.LastName);

        }
        [Test]
        public void RetrieveExistingCustomerWithAddresses()
        {
            var customerRepository = new CustomerRepository();
            var expectedCustomer = new Customer(1)
            // Create new object of Customer type and we set the properties JSON style 
            {
                Email = "fbaggins@gomail.com", // same as expectedCustomer.Email = "fbaggins@gomail.com";
                FirstName = "Frodo",
                LastName = "Baggins",
      // From here on out we hard-code fill the AddressList<Address> with as many Address obj. we want-JSON style
                AddressList = new List<Address>()
                { 
                new Address()
                {
                AddressType = 1,
                City = "Sofia",
                Country = "Bulgaria",
                PostalCode = "1404",
                State = "Shopluka",
                StreetLine1 = "Georges Tri",
                StreetLine2 = "Georges Trion"
                },
                new Address()
                {
                AddressType = 2,
                City = "Petrich",
                Country = "Bulgaria",
                PostalCode = "1303",
                State = "Petrich1",
                StreetLine1 = "Arena Tri",
                StreetLine2 = "Arena Trion"
                }
                }
            };

            var actualCustomer = customerRepository.Retrieve(1);

            Assert.AreEqual(expectedCustomer.CustomerId, actualCustomer.CustomerId);
            Assert.AreEqual(expectedCustomer.Email, actualCustomer.Email);
            Assert.AreEqual(expectedCustomer.FirstName, actualCustomer.FirstName);
            Assert.AreEqual(expectedCustomer.LastName, actualCustomer.LastName);

            int count = actualCustomer.AddressList.Count;
            for (int i = 0; i < count-1; i++)
            {
                Assert.AreEqual(expectedCustomer.AddressList[i].AddressType,
                    actualCustomer.AddressList[i].AddressType);
                Assert.AreEqual(expectedCustomer.AddressList[i].City,
                    actualCustomer.AddressList[i].City);
                Assert.AreEqual(expectedCustomer.AddressList[i].Country,
                    actualCustomer.AddressList[i].Country);
                Assert.AreEqual(expectedCustomer.AddressList[i].PostalCode,
                    actualCustomer.AddressList[i].PostalCode);
                Assert.AreEqual(expectedCustomer.AddressList[i].State,
                    actualCustomer.AddressList[i].State);
                Assert.AreEqual(expectedCustomer.AddressList[i].StreetLine1,
                    actualCustomer.AddressList[i].StreetLine1);
                Assert.AreEqual(expectedCustomer.AddressList[i].StreetLine2,
                    actualCustomer.AddressList[i].StreetLine2);
                
            }

        }
    }
}
