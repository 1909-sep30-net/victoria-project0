using Project0.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.DataAccess
{
    public class DataRespository : IRepository
    {
        /// <summary>
        /// Get a restaurant by ID.
        /// </summary>
        /// <returns>The restaurant</returns>
        public Library.Models.Store GetStoreById(int id) =>
            Mapper.MapStore(ClothesEncountersContext.Stores.Find(id));
    }
}
