using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Shirt
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Products must have a name", nameof(value));

                name = value;
            }
        }

        private decimal price;
        public decimal Price
        {
            get => price;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Products must have a price", nameof(value));

                price = value;
            }
        }

        private int productId;

        public int ProductId
        {
            get => productId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Products must have an ID", nameof(value));

                productId = value;
            }
        }



        public Shirt()
            {}
        public Shirt(string name, decimal price, int productId)
        {
            Name = name;
            Price = price;
            ProductId = productId;

        }
    }

}




    