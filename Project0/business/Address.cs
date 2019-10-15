//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BusinessLogic
//{
//    public class Address
//    {
//        public string Street
//        {
//            get => Street;
//            set
//            {
//                if (value == string.Empty)
//                    throw new ArgumentException("Must have an address", nameof(value));

//                Street = value;
//            }

//        }
//        public string City
//        {
//            get => City;
//            set
//            {
//                if (value == string.Empty)
//                    throw new ArgumentException("Must have a city", nameof(value));

//                City = value;
//            }

//        }

//        public string State
//        {
//            get => State;
//            set
//            {
//                if (value == string.Empty)
//                    throw new ArgumentException("Must have an state", nameof(value));

//                State = value;
//            }

//        }

     

//        public string Zip
//        {
//            get => Zip;
//            set
//            {
//                if (value.Length != 5)
//                    throw new ArgumentException("Must have a zipcode", nameof(value));

//                Zip = value;
//            }

//        }

//        public Address(string street, string city, string state, string zip)
//        {
//            Street = street;
//            City = city;
//            State = state;
//            Zip = zip;
//        }

//        public string PrintAddress()
//        {
//            string address = "";
//            address += $"{Street} {City} {State} {Zip}";
//            return address;
//        }
//    }
//}
