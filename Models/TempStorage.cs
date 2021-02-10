using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class TempStorage
    {
        private static List<RestaurantSuggestion> restaurantLists = new List<RestaurantSuggestion>();

        public static IEnumerable<RestaurantSuggestion> RestaurantLists => restaurantLists;

        public static void AddApplication(RestaurantSuggestion restaurantList)
        {
            restaurantLists.Add(restaurantList);
        }
    }
}
