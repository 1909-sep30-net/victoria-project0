using Project0.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BusinessLogic;
using System.Linq;

namespace Project0.DataAccess
{
    public class DataRepository
    {
        private ClothesEncountersContext context;

        public DataRepository(ClothesEncountersContext context)
        {
            //context = new ClothesEncountersContext();
            this.context = context;

        }

        public BusinessLogic.Store GetStoreById(int id) => Mapper.MapStore(context.Stores.Find(id));

        public void AddNewCustomer(Customer _cust)
        {
            Customers Cust = Mapper.MapDbCustomer(_cust);
            context.Add(Cust);
            context.SaveChanges();
        }

        public void AddNewOrder(Order _ord, OrderDetail _od1)
        {
            Orders Ord = Mapper.MapDbOrders(_ord, _od1);
            context.Add(Ord);
            context.SaveChanges();
        }

    

        public List<BusinessLogic.Customer> GetAllCustomers()
        {
            IQueryable<Project0.DataAccess.Entities.Customers> customers = context.Customers
                .AsNoTracking();

            return customers.Select(Mapper.MapCustomer).ToList();
           

        }

        public List<BusinessLogic.Store> GetAllStores()
        {
            IQueryable<Project0.DataAccess.Entities.Stores> stores = context.Stores
                .AsNoTracking();

            return stores.Select(Mapper.MapStore).ToList();


        }

        public Customer GetCustomerByFirstName(string firstName)

            => context.Customers.Select(Mapper.MapCustomer).Where(c => c.FirstName == firstName).FirstOrDefault();


        public Dictionary<Shirt,int> GetInventoryByStoreId(int storeId)
        {
            using var context = GetContext();
            List<Inventory> getInvent = context.Inventory.Where(i => i.StoreId == storeId).ToList();
            Dictionary<Shirt, int> burrito = new Dictionary<Shirt, int>();
            foreach (Inventory  item in getInvent)
            {
                burrito.Add(new Shirt() { Name = context.Products.Single(p => p.ProductId == item.ProductId).Name, Price = context.Products.Single(p => p.ProductId == item.ProductId).Price, ProductId = item.ProductId}, (int) item.Quantity);
            }
            return burrito;

        }

        public static ClothesEncountersContext GetContext()
        {
            string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<ClothesEncountersContext> options = new DbContextOptionsBuilder<ClothesEncountersContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new ClothesEncountersContext(options);
        }



        public static class Dependencies

        {

            //public static IRepository CreateStoreRepository()

            //{

            //    var optionsBuilder = new DbContextOptionsBuilder<ClothesEncountersContext>();

            //    optionsBuilder.UseSqlServer(SecretConfiguration.ConnectionString);

            //    var context = new ClothesEncountersContext(optionsBuilder.Options);

            //    return new DataRepository(context);

            //}


        }

        //public GetStoreByIdWithInventory(int StoreId)
        //{ return Inventory
        //        {
        //            var Stores = context.Stores.Include(s => s.Inventory).ThenInclude(i => i.Product).FirstOrDefault(s => s.Id == id)
        //        };
        //}




    }
}

