using System;
using System.Collections.Generic;
using System.Text;

namespace business
{
    public class Order
    {
        public Store storeLocation;

        public Customer orderedBy;

        public DateTime dateOfOrder = new DateTime();

        public List<string> cart = new List<string>();



    }
}
