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

        //convert DB Stores to BL Store 
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

        //Convert BL Store into DB Stores
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

        //converts DB Products to  BL Shirt 
        public static BusinessLogic.Shirt MapShirt(Entities.Products products)
        {
            return new BusinessLogic.Shirt(products.Name, products.Price, products.ProductId);

            /*{

                Name = products.Name,

                Price = products.Price,

                ProductId = products.ProductId


            };*/
        }

        //converting BL Shirt to DB Products  
        public static Project0.DataAccess.Entities.Products MapDbProduct(Shirt shirt)
        {

            return new Project0.DataAccess.Entities.Products

            {

                Name = shirt.Name,

                Price = shirt.Price,

                ProductId = shirt.ProductId


            };

        }




        // converts  DB customers to BL customer 
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

        //converts BL customer into DB customers
        public static Project0.DataAccess.Entities.Customers MapDbCustomer(Customer customer)
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

        //Convert DB Orders to BL Order  
        public BusinessLogic.Order MapOrder(Entities.Orders orders)
        {
            return new BusinessLogic.Order

            {

                OrderId = orders.OrderId,

                DateOfOrder = orders.OrderDate,

                OrderTotal = orders.Total


            };


        }

        //Convert BL Order to DB Orders 
        public Project0.DataAccess.Entities.Orders MapDbOrders(Order order)
        {
            return new Project0.DataAccess.Entities.Orders

            {

                OrderId = order.OrderId,

                OrderDate = order.DateOfOrder,

                Total = order.OrderTotal


            };


        }


        //Connecting Inventory Dictionary to DB inventory
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
                i => i.Quantity ?? throw new ArgumentException ("Quantity can't be null.") )
            };
        }


    }
           

 }


    


