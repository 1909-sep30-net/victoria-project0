using System;
using System.Collections.Generic;
using System.Text;

namespace business
{
    public class Store
    {
        public string name;
        public int storeId;
        public Dictionary<Shirt, int> Inventory = new Dictionary<Shirt, int>(); 
        



    }
}
