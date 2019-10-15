using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BusinessLogic;

namespace Project0.DataAccess 
{
    public static class Mapper
    {
        public static BusinessLogic.Models.Stores MapRestaurantWithReviews(Entities.Stores stores)

        {

            return new BusinessLogic.Models.Restaurant

            {

                Id = stores.Id,

                Name = stores.Name,

                Reviews = restaurant.Review.Select(Map).ToList()

            };

        }
    }
}
