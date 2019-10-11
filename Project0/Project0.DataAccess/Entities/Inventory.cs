using System;
using System.Collections.Generic;

namespace Project0.DataAccess.Entities
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public int StoreNum { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual Products Product { get; set; }
        public virtual Stores StoreNumNavigation { get; set; }
    }
}
