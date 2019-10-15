using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Shirt
    {
        public string Name
        {
            get => Name;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Products must have a name", nameof(value));

                Name = value;
            }
        }

        public decimal Price
        {
            get => Price;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Products must have a price", nameof(value));

                Price = value;
            }
        }

        public int ProductId
        {
            get => ProductId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Products must have an ID", nameof(value));

                ProductId = value;
            }
        }




        public Shirt(string name, decimal price, int productId)
        {
            Name = name;
            Price = price;
            ProductId = productId;

        }
    }

}




    