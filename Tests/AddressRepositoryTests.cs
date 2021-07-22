using ACM.BL;
using NUnit.Framework;
using Serialize;


namespace ACM.BL_Test
{
    class AddressRepositoryTests
    {
        [OneTimeSetUp]
        public void Setup()
        {
        }

        [Test]
        public void RetrieveValidAddress()
        {
            var addressRepository = new AddressRepository();
            var address = new Address(1)
            {
                AddressType = 23,
                City = "Plovdiv",
                Country = "Bulgaria",
                PostalCode = "1220",
                State = "California",
                StreetLine1 = "Boris Tri",
                StreetLine2 = "Boris Trion"
            };

            var actualAddress = addressRepository.Retrieve(1);

            Assert.AreEqual(address.AddressType, actualAddress.AddressType);
            Assert.AreEqual(address.City, actualAddress.City);
            Assert.AreEqual(address.Country, actualAddress.Country);
            Assert.AreEqual(address.PostalCode, actualAddress.PostalCode);
            Assert.AreEqual(address.State, actualAddress.State);
            Assert.AreEqual(address.StreetLine1, actualAddress.StreetLine1);
            Assert.AreEqual(address.StreetLine2, actualAddress.StreetLine2);

        }
        [Test]
        public void TestValidSaveOperation()
        {
            var addressRepository = new AddressRepository();
            var updatedAddress = new Address(1)
            {
                AddressType = 23,
                City = "Plovdiv",
                Country = "Bulgaria",
                PostalCode = "1220",
                State = "California",
                StreetLine1 = "Boris Tri",
                StreetLine2 = "Boris Trion",
                HasChanges = true

            };

            var actualAddress = addressRepository.Save(updatedAddress);

            Assert.IsTrue(actualAddress);
        }

        [Test]
        public void TestInvalidSaveOperation_MissingPostalCode()
        {
            var addressRepository = new AddressRepository();
            var updatedAddress = new Address(1)
            {
                AddressType = 23,
                City = "Plovdiv",
                Country = "Bulgaria",
                PostalCode = null,
                State = "California",
                StreetLine1 = "Boris Tri",
                StreetLine2 = "Boris Trion",
                HasChanges = true

            };

            var actualAddress = addressRepository.Save(updatedAddress);

            Assert.IsFalse(actualAddress);
        }

    }
}
