using System;
using System.Collections.Generic;
using System.Text;

namespace business
{
    public class Customer
    {
        public string firstName
        {
            get => firstName;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Must have a first name", nameof(value));

                firstName = value;
            }
        }
        public string lastName
        {
            get => lastName;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Must have a last name", nameof(value));

                lastName = value;
            }

        }

        public string address
        {
            get => address;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Must have an address", nameof(value));

                address = value;
            }

        }




        public int id
        {
            get => id;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid Customer ID", nameof(value));
                id = value;
            }
        }
    }
}

       

    



  
        




