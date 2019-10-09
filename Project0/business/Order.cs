using System;
using System.Collections.Generic;
using System.Text;

namespace business
{
    public class Order
    {
        public Store storeId;

        public Customer orderedBy;

        public DateTime dateOfOrder = new DateTime();

        public Dictionary<Shirt, int> cart = new Dictionary<Shirt, int>();



    }
}
