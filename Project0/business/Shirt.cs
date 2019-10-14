using System;
using System.Collections.Generic;
using System.Text;

namespace business
{
    public class Shirt
    {
        public string name { 
            get => name;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Products must have a name", nameof(value));

                name = value;
            }
        }

        public decimal price {
            get => price;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Products must have a price", nameof(value));

                price = value;
            }
        }

        public int productId {
            get => productId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Products must have an ID", nameof(value));

                productId= value;
            }
        }
    

        public int productQuantity {
        get => productQuantity;
        set
        {
            if (value < 0)
                throw new ArgumentException("Cannot have negative product quantity", nameof(value));

            productQuantity = value;
        }
    }
}
        


    }
}



    