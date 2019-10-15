using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Order
    {
        public int StoreId
        {
            get => StoreId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("All stores have an ID", nameof(value));

                StoreId = value;
            }
        }


        public Customer orderedBy;

        public DateTime dateOfOrder = new DateTime();

        public Dictionary<Shirt, int> cart = new Dictionary<Shirt, int>();



    }
}





