using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Order
    {
        public Store storeId;

        public Customer orderedBy;

        public DateTime dateOfOrder = new DateTime();

        public Dictionary<Shirt, int> cart = new Dictionary<Shirt, int>();



    }
}






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