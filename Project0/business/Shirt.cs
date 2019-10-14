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

        public double Price
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


        public int ProductQuant
        {
            get =>ProductQuant;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Cannot have negative product quantity", nameof(value));

                ProductQuant = value;
            }
        }

        public Shirt(string name, double price, int productId, int productQuant)
        {
            Name = name;
            Price = price;
            ProductId = productId;
            ProductQuant = productQuant;
        }
    }

}




    