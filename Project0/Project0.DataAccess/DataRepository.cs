using Project0.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Project0.DataAccess
{
    public class DataRepository : IRepository
    {
        private ClothesEncountersContext context;

        public DataRepository(object context)
        {
            context = new ClothesEncountersContext();
        }

        public BusinessLogic.Store GetStoreById(int id) => Mapper.MapStore(context.Stores.Find(id));
    }

    

    public static class Dependencies

        {

            public static IRepository CreateStoreRepository()

            {
                
                var optionsBuilder = new DbContextOptionsBuilder<ClothesEncountersContext>();

                optionsBuilder.UseSqlServer(SecretConfiguration.ConnectionString);

                var context = new ClothesEncountersContext(optionsBuilder.Options);

                return new DataRepository(context);

            }



           
        }

    
}

