using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLogic
{
    public class Store
    {
        public string Name = "ClothesEncounters";

        private int storeId;
        public int StoreId
        {
            get => storeId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid Store ID", nameof(value));
                storeId = value;
            }
        }

        private string street;
        public string Street
        {
            get => street;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Must have an address", nameof(value));

                street = value;
            }

        }
        private string city;
        public string City
        {
            get => city;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Must have a city", nameof(value));

                city = value;
            }

        }

        private string state;
        public string State
        {
            get => state;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Must have an state", nameof(value));

                state = value;
            }

        }


        private string zip;
        public string Zip
        {
            get => zip;
            set
            {
                if (value.Length != 5)
                    throw new ArgumentException("Must have a zipcode", nameof(value));

                zip = value;
            }

        }
        


        public Dictionary<Shirt, int> Inventory = new Dictionary<Shirt, int>();
        
        



    }
}
