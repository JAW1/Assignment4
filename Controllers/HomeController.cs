using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Index and passing list of restaurant information
        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                restaurantList.Add(string.Format($"#{r.RestaurantRank}: Name: {r.RestaurantName}, " +
                    $"My Favorite Dish: {r.FavoriteDish}, Address: {r.Address}, Phone: {r.RestaurantPhone}, Website: {r.WebsiteLink}"));
            }
            return View(restaurantList);
        }

        //submit suggestions before post
        [HttpGet]
        public IActionResult SubmitSuggestions()
        {
            return View();
        }

        //Suggestion Submittion Application
        [HttpPost]
        public IActionResult SubmitSuggestions(RestaurantSuggestion restaurantLists)
        {
            TempStorage.AddApplication(restaurantLists);
            //Debug.WriteLine("Name: " + appResponse.Name);
            return View("Confirmation", restaurantLists); //"Confirmation", appResponse
        }
        
        //View New Restaurant Suggestions
        public IActionResult ViewSuggestions()
        {
            return View(TempStorage.RestaurantLists);
        }

        //Privacy Page
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
