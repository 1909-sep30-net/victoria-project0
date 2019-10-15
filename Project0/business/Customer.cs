using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Customer
    {
        
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


        //public Customer(string firstName, string lastName, Address address)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    CustomerAddress = address;
        //}

    }
}

       

    



  
        




