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

        public List<BusinessLogic.Customer> GetAllCustomers()
        {
            IQueryable<Project0.DataAccess.Entities.Customers> customers = context.Customers
                .AsNoTracking();

            return customers.Select(Mapper.MapCustomer).ToList();
           

        }

        public Customer GetCustomerByFirstName(string firstName)

            => context.Customers.Select(Mapper.MapCustomer).Where(c => c.FirstName == firstName).FirstOrDefault();


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

