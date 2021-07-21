using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        // establish composition relationship between CustomerRepo and AddressRepo w. property and ctor below
        private AddressRepository addressRepository { get; set; }   

        public CustomerRepository()
        {
            this.addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            // code that retrieves the defined user

            // temp hard-coded values to return a customer
            if (customerId == 1)
            {
                customer.Email = "fbaggins@gomail.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveCustomerId(customerId).ToList();
            }

            return customer;
        }
        public bool Save(Customer customer)
        {
            //TODO save the passed in customer
            return true;
        }
    }
}
