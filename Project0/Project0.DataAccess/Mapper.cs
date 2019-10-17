using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BusinessLogic;
using Project0.DataAccess.Entities;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using Project0.DataAccess;


namespace Project0.DataAccess
{
    public class Mapper
    {

        //convert DB Stores to BL Store 
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

        //Convert BL Store into DB Stores
        public static Project0.DataAccess.Entities.Stores MapDbStores(Store store)

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
        public static BusinessLogic.Order MapOrder(Orders orders)
        {
            return new BusinessLogic.Order

            {

                OrderId = orders.OrderId,

                DateOfOrder = orders.OrderDate,

                OrderTotal = orders.Total,

                StoreId = orders.StoreId,

                CustomerId = orders.CustomerId,

                //cart = MapCart()*/




            };


        }

        //Convert BL Order to DB Orders 
        public static Project0.DataAccess.Entities.Orders MapDbOrders(Order order, OrderDetail orderDetail)
        {
            ICollection<OrderDetail> o = new List<OrderDetail>() { orderDetail };

            

            return new Project0.DataAccess.Entities.Orders

            {

                OrderId = order.OrderId,

                OrderDate = order.DateOfOrder,

                Total = order.OrderTotal,

                StoreId = order.StoreId,

                CustomerId = order.CustomerId,

                OrderDetail = o



            };


        }

        public Project0.DataAccess.Entities.OrderDetail MapDbOrderDetails()
        {
            return new Project0.DataAccess.Entities.OrderDetail
            {

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
                i => i.Quantity ?? throw new ArgumentException("Quantity can't be null."))
            };
        }

      

        //method to get context
        public static ClothesEncountersContext GetContext()
        {
            string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<ClothesEncountersContext> options = new DbContextOptionsBuilder<ClothesEncountersContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new ClothesEncountersContext(options);
        }

       

        // map order cart to order details
        public static BusinessLogic.Order MapCart(IEnumerable<OrderDetail> orderDetail)
        {
            

            Dictionary<Shirt, int> dic2 = new Dictionary<Shirt, int>();

            foreach(OrderDetail od in orderDetail)
            {
                dic2.Add(new Shirt(od.Product.Name, od.Product.Price, od.Product.ProductId), od.ProductQuant);           
            }

            return new BusinessLogic.Order
            {
                OrderId = orderDetail.Single().OrderId,

                cart = dic2
            };

           

        }



        //Connecting DB Inventory to inventory dictionary
        public Project0.DataAccess.Entities.Stores MapDbInventory(Store store)
        {
    /* return new Project0.DataAccess.Entities.Stores

    {
        StoreId = store.StoreId,
        Inventory = store.Inventory.ToDictionary(i =>
        {
            // make a product from a shirt

            return new Products(i.Shirt.Name, i.Shirt.Price, i.Shirt.ProductId);

        },
        i => i.Quantity ?? throw new ArgumentException("Quantity can't be null."))
    };*/

    Project0.DataAccess.Entities.Stores stores = new Project0.DataAccess.Entities.Stores();
            stores.StoreId = store.StoreId;
            //stores.Inventory = new HashSet<Entities.Inventory>();

            foreach (Shirt s in store.Inventory.Keys)
            {
                stores.Inventory.Add(new Project0.DataAccess.Entities.Inventory { StoreId = store.StoreId, ProductId = s.ProductId, Quantity = store.Inventory[s]});
            }

            return stores;
        }



    }
           

 }


    


