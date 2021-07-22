using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EntityBase
    {
        // Constructors
        public Customer()
        {
            AddressList = new List<Address>();
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        // fields and properties

        public int CustomerType { get; set; }
        public List<Address> AddressList { get; set; }  // We need to initialize the List, so it doesn't throw null
        public int CustomerId { get; private set; }     
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get ; set ; }

        public string FullName
        {
            get
            {
                return CheckForMissingFirstOrLastNames(LastName);
            }
        }
        public static int InstanceCount { get; set; }

        // Methods
        public override string ToString() => FullName; // short for return FullName
        public override bool Validate()
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(LastName) ||
                String.IsNullOrEmpty(Email))
            {
                isValid = false;
            }
            return isValid;
        }
        private string CheckForMissingFirstOrLastNames(string lastName)
        {
            string fullName = lastName;
            if (!String.IsNullOrEmpty(FirstName))
            {
                if (!String.IsNullOrEmpty(fullName))
                {
                    fullName += ", ";
                }
                fullName += FirstName;
            }
            return fullName;
        }
    }
}
