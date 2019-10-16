using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Order
    {
        private int orderId;
        public int OrderId
        {
            get => orderId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("All orders must have an ID", nameof(value));

                orderId = value;
            }
        }


        public Customer orderedBy;

        public DateTime DateOfOrder = new DateTime();

        public Dictionary<Shirt, int> cart = new Dictionary<Shirt, int>();

        private decimal orderTotal;
        public decimal OrderTotal
        {
            get => orderTotal;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Order total cannot be negative", nameof(value));

                orderTotal = value; 
            }
        }

    }
}





