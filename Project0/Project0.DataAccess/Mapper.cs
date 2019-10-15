using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BusinessLogic;
using Project0.DataAccess.Entities;
using System.Collections;

namespace Project0.DataAccess
{
    public class Mapper
    {

        //convert BL Store to DB Stores
        public BusinessLogic.Store MapStore(Entities.Stores stores)

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

        //Convert DB Stores into BL Store
        public Project0.DataAccess.Entities.Stores MapDbStores(Store store)

        {

            return new Project0.DataAccess.Entities.Stores

            {

                StoreId = store.StoreId,

                Address = store.Street,

                City = store.City,

                State = store.State,

                Zipcode = store.Zip

            };

        }
        internal static Store MapStore(object p)
        {
            throw new NotImplementedException();
        }

        //converts BL Shirt to DB Product
        public static BusinessLogic.Shirt MapShirt(Entities.Products products)
        {
            return new BusinessLogic.Shirt(products.Name, products.Price, products.ProductId);

            /*{

                Name = products.Name,

                Price = products.Price,

                ProductId = products.ProductId


            };*/
        }

        //converting DB Products to BL Shirt
        public Project0.DataAccess.Entities.Products MapDbProduct(Shirt shirt)
        {

            return new Project0.DataAccess.Entities.Products

            {

                Name = shirt.Name,

                Price = shirt.Price,

                ProductId = shirt.ProductId


            };

        }

        //public static Dictionary<Shirt, int> MapInventory(Entities.Stores store)
        //{

        //}

        //public void MapInventory(ref Entities.Stores store, Dictionary<Shirt, int> inventory)
        //{

        //}


        // converts BL customer to DB customers
        public BusinessLogic.Customer MapCustomer(Entities.Customers customers)
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

        //converts DB customers into BL customer
        public Project0.DataAccess.Entities.Customers MapDbCustomer(Customer customer)
        {
            return new Project0.DataAccess.Entities.Customers
            {
                FirstName = customer.FirstName,

                LastName = customer.LastName,

                Address = customer.Street,

                City = customer.City,

                State = customer.State,

                Zipcode = customer.Zip,

                CustomerId = customer.Id
            };
        }

        //Convert BL Order to DB Orders
        public BusinessLogic.Order MapOrder(Entities.Orders orders)
        {
            return new BusinessLogic.Order

            {

                OrderId = orders.OrderId,

                DateOfOrder = orders.OrderDate,

                OrderTotal = orders.Total


            };


        }

        //Convert DB Orders to BL Order
        public Project0.DataAccess.Entities.Orders MapDbOrders(Order order)
        {
            return new Project0.DataAccess.Entities.Orders

            {

                OrderId = order.OrderId,

                OrderDate = order.DateOfOrder,

                Total = order.OrderTotal


            };


        }


        //
        public BusinessLogic.Store MapInventory(Stores stores)
        {
            return new BusinessLogic.Store

            {
                StoreId = stores.StoreId,
                Inventory = stores.Inventory.ToDictionary(i =>
                {
                    // make a shirt fom a product
                    //i.Product;
                    return new Shirt(i.Product.Name, i.Product.Price, i.Product.ProductId);
                    
                },
                i => i.Quantity?? throw new ArgumentException ("Quantity can't be null.") )
            };
        }


            }
            //var list = new List<int> { 3, 6, 2, 9 };
            //var squares = list.Select(n => n * n).ToList(); // { 9, 36, 4, 81 }


        }


    


