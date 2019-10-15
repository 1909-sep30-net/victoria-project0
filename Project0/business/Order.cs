using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Order
    {
        public int OrderId
        {
            get => OrderId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("All stores have an ID", nameof(value));

                OrderId = value;
            }
        }


        public Customer orderedBy;

        public DateTime DateOfOrder = new DateTime();

        public Dictionary<Shirt, int> cart = new Dictionary<Shirt, int>();

        public decimal OrderTotal
        {
            get => OrderTotal;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Order total cannot be negative", nameof(value));

                OrderTotal = value; 
            }
        }

    }
}





