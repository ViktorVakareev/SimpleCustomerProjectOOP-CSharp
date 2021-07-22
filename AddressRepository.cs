using System.Collections;
using System.Collections.Generic;

namespace ACM.BL
{
    public class AddressRepository
    {
       
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            // code that retrieves the defined user

            // temp hard-coded values to return a customer
            if (addressId == 1)
            {
                address.AddressType = 23;
                address.City = "Plovdiv";
                address.Country = "Bulgaria";
                address.PostalCode = "1220";
                address.State = "California";
                address.StreetLine1 = "Boris Tri";
                address.StreetLine2 = "Boris Trion";

            }

            return address;
        }
        public IEnumerable<Address> RetrieveCustomerId(int customerId)
        {
            // code that retrieves the defined addresses for the customer

            // temp hard-coded values to return a list of addresses for a customer
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                City = "Sofia",
                Country = "Bulgaria",
                PostalCode = "1404",
                State = "Shopluka",
                StreetLine1 = "Georges Tri",
                StreetLine2 = "Georges Trion"
            };
            addressList.Add(address);

             address = new Address(2)
            {
                AddressType = 2,
                City = "Petrich",
                Country = "Bulgaria",
                PostalCode = "1303",
                State = "Petrich1",
                StreetLine1 = "Arena Tri",
                StreetLine2 = "Arena Trion"
            };
            addressList.Add(address);

            return addressList;
        }
        public bool Save(Address address)
        {
            bool success = true;
            if (address.HasChanges)
            {
                if (address.isValid)
                {
                    if (address.IsNew)
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
