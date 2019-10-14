using System;
using System.Collections.Generic;
using System.Text;

namespace business
{
    public class Customer
    {
        public string firstName { get; set; } 
        public string lastName { get; set; }
        public string address { get; set; }

        public int id;

        //public int Id
        //{
        //    get id;
        //    set
        //    {
        //        if (value <= 0)
        //            throw new ArgumentException("Invalid Customer ID", nameof(value));
        //    }
        //}


    }
}





    //public class Customer
    //{
    //    private int _id; // customers ID
    //    private string _firstName; // customers first name
    //    private string _lastName; // custumers last name

    //    public int Id
    //    {
    //        get => _id;
    //        set
    //        {
    //            if (value < 0)
    //                throw new ArgumentException("ID cannot be < 0", nameof(value));

    //            _id = value;
    //        }
    //    }
    //    public string FirstName
    //    {
    //        get => _firstName;
    //        set
    //        {
    //            if (value == string.Empty)
    //                throw new ArgumentException("First name cannot be empty", nameof(value));

    //            _firstName = value;
    //        }
    //    }
    //    public string LastName
    //    {
    //        get => _lastName;
    //        set
    //        {
    //            if (value == string.Empty)
    //                throw new ArgumentException("Last name cannot be empty", nameof(value));

    //            _lastName = value;
    //        }
    //    }
    //    public List<Order> Orders { get; set; } = new List<Order>();

    //    public decimal TotalPurchases
    //    {
    //        get
    //        {
    //            if (Orders?.Count > 0)
    //            {
    //                return Orders.Sum(p => p.TotalPrice);
    //            }

    //            return 0.00M;
    //        }
    //    }
    //}



