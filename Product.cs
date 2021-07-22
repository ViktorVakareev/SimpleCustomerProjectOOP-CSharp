using System;
using System.Collections.Generic;
using CommonFunctionalityLibrary;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {
        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }

        private string _productName;
        public string ProductName {
            get {
                //var stringHandler = new StringHandler();  // StringHandler class made static

                return _productName.InsertSpacesInProductNames(); 
            }
            set { _productName = value; }
        }
        public double? CurrentPrice { get; set; }   // Nullable type - like double->Double in Java
        // Implementation of Illogable interface
        public string Log() =>
            $"{ProductId}: {ProductName} Details: {ProductDescription} Status: {entityState.ToString()}";
        public override string ToString()
        {
            return ProductName;
        }
        public override bool Validate()
        {
            bool isValid = true;
            if ((CurrentPrice == null) || (ProductId <= 0))
            {
                isValid = false;
            }
            return isValid;
        }

    }
}
