using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLogic
{
    public class Store
    {
        public string Name = "ClothesEncounters";

        public int StoreId
        {
            get => StoreId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid Store ID", nameof(value));
                StoreId = value;
            }
        }

        public Address StoreAddress { get; set; }


        public Dictionary<Shirt, int> Inventory = new Dictionary<Shirt, int>();
        
        



    }
}
