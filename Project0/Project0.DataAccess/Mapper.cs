using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BusinessLogic;

namespace Project0.DataAccess
{
    public static class Mapper
    {
        public static BusinessLogic.Store MapStore(Entities.Stores stores)

        {

            return new BusinessLogic.Store

            {

                StoreId = stores.StoreId,

                Street = stores.Address,

                City = stores.City,

                State = stores.State,

                Zip = stores.Zipcode

            };

        }

        public static BusinessLogic.Shirt MapShirt(Entities.Products products)
        {
            return new BusinessLogic.Shirt

            {

                Name = products.Name,

                Price = products.Price,

                ProductId = products.ProductId


            };
        }

        public static Dictionary<Shirt, int> MapInventory(Entities.Stores store)
        {

        }

        public static void MapInventory(ref Entities.Stores store, Dictionary<Shirt, int> inventory)
        {

        }
        public static BusinessLogic.Customer MapCustomer(Entities.Customers customers)
        {
            return new BusinessLogic.Customer

            {

                FirstName = customers.FirstName,

                LastName = customers.LastName,

                Street = customers.Address,

                City = customers.City,

                State = customers.State,

                Zip = customers.Zipcode,

                Id = customers.CustomerId


            };
        }

         public static BusinessLogic.Order MapOrder(Entities.Orders orders)
        {
             return new BusinessLogic.Order

                {

                  OrderId = orders.OrderId,

                  DateOfOrder = orders.OrderDate,

                  OrderTotal = orders.Total


                };


            }
        }
}
