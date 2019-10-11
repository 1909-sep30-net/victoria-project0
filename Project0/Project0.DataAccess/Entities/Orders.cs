using System;
using System.Collections.Generic;

namespace Project0.DataAccess.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public int StoreNum { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Stores StoreNumNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
