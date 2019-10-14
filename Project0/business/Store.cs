using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLogic
{
    public class Store
    {
        public string Name;

        public int StoreId;

        public Address StoreAddress { get; set; }


        public Dictionary<Shirt, int> Inventory = new Dictionary<Shirt, int>();
        
        



    }
}
