using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Restaurant
    {
        //defining the model attributes
        [Required]
        public int RestaurantRank { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; } = "It's All Tasty"; //sentence here makes it default
        [Required]
        public string? Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public long? RestaurantPhone { get; set; }
        public string? WebsiteLink { get; set; } = "Coming Soon";

        //defining list instance
        public static Restaurant[] GetRestaurants()
        {
            Restaurant rank1 = new Restaurant
            {
                RestaurantRank = 1,
                RestaurantName = "Pita Pit",
                FavoriteDish = "Souvlaki",
                Address = "1000 N. University",
                RestaurantPhone = 8013334565,
                WebsiteLink = "pitapitusa.com"
            };
            Restaurant rank2 = new Restaurant
            {
                RestaurantRank = 2,
                RestaurantName = "Noodles and Company",
                //leave favorite dish blank
                Address = "1100 N. University",
                RestaurantPhone = 8014447867,
                WebsiteLink = "www.noodles.com"
            };
            Restaurant rank3 = new Restaurant
            {
                RestaurantRank = 3,
                RestaurantName = "Mo'Bettahs",
                FavoriteDish = "Teriyaki Chicken",
                Address = "2000 N. University",
                RestaurantPhone = 8013764865,
                //leave Website Blank
            };
            Restaurant rank4 = new Restaurant
            {
                RestaurantRank = 4,
                RestaurantName = "Cupbop",
                FavoriteDish = "Combo Bop",
                Address = "800 N. University",
                RestaurantPhone = 8019037865,
                WebsiteLink = "cupbop.com"
            };
            Restaurant rank5 = new Restaurant
            {
                RestaurantRank = 1,
                RestaurantName = "Costa Vida",
                FavoriteDish = "Chicken Burrito",
                Address = "900 N. University",
                RestaurantPhone = 8013989565,
                WebsiteLink = "www.costavida.com"
            };

            return new Restaurant[] { rank1, rank2, rank3, rank4, rank5 };
        }

    }

    public class RestaurantSuggestion
    {
        //defining the model attributes
        [Required]
        public string SuggestorName { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string FavoriteDish { get; set; } = "It's All Tasty"; //sentence here makes it default

        //requiring and making datatype phonenumber, the validation is in the HTML
        [DataType(DataType.PhoneNumber)]
        [Required]
        public long? RestaurantPhone { get; set; }
    }
}
