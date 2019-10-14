using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Customer
    {
        Address _address = null;
        public string FirstName
        {
            get => FirstName;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Must have a first name", nameof(value));

                FirstName = value;
            }
        }
        public string LastName
        {
            get => LastName;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Must have a last name", nameof(value));

                LastName = value;
            }

        }

        public Address CustomerAddress { get; set; }


        public int Id
        {
            get => Id;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid Customer ID", nameof(value));
                Id = value;
            }
        }


        public Customer(string firstName, string lastName, Address address, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            CustomerAddress = address;
            Id = id;
        }

    }
}

       

    



  
        




