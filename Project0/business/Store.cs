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

        public string Street
        {
            get => Street;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Must have an address", nameof(value));

                Street = value;
            }

        }
        public string City
        {
            get => City;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Must have a city", nameof(value));

                City = value;
            }

        }

        public string State
        {
            get => State;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Must have an state", nameof(value));

                State = value;
            }

        }



        public string Zip
        {
            get => Zip;
            set
            {
                if (value.Length != 5)
                    throw new ArgumentException("Must have a zipcode", nameof(value));

                Zip = value;
            }

        }
        


        public Dictionary<Shirt, int> Inventory = new Dictionary<Shirt, int>();
        
        



    }
}
