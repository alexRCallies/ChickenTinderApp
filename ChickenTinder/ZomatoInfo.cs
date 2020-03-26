using ChickenTinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenTinder
{
    public static class ZomatoInfo

    {

        const string url = "https://developers.zomato.com/api/v2.1/";

        const string apiKey = "f21a839a0c741e047d2f3ff9f5e9a6b4";



        public static RestaurantList GetRestaurants()
        {
            string urlParameters = $"search?entity_id=59&entity_type=city&apikey=f21a839a0c741e047d2f3ff9f5e9a6b4";

            var response = APICall.RunAsync<RestaurantList>(url, urlParameters).GetAwaiter().GetResult();

            return response;
        }

    }
}
