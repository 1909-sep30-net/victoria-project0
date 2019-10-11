using System;
using System.Collections.Generic;

namespace Project0.DataAccess.Entities
{
    public partial class Products
    {
        public Products()
        {
            Inventory = new HashSet<Inventory>();
            OrderDetail = new HashSet<OrderDetail>();
        }

        public string Name { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
