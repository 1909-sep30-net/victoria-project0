using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Customer
    {
        private string firstName;
        public string FirstName
        {
          
            get => firstName;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Must have a first name", nameof(value));
                
                firstName = value;
            }
        }

        private string lastName;
        public string LastName
        {
            get => lastName;
            set
            {
                if (value == string.Empty)
                    throw new ArgumentException("Must have a last name", nameof(value));

                lastName = value;
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


        private int id;
        public int Id
        {
            get => id;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid Customer ID", nameof(value));
                id = value;
            }
        }

        public Customer()
        { }
        public Customer(string firstName, string lastName, string street, string city, string state, string zip)
        {
            FirstName = firstName;
            LastName = lastName;
            Street = street;
            City = city;
            State = state;
            Zip = zip;

        }

    }
}

       

    



  
        




