﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenTinder.Models
{
    public class RestaurantList
    {
        [JsonProperty("results_found")]

        public int ResultsFound { get; set; }



        [JsonProperty("results_shown")]

        public int ResultsShown { get; set; }



        [JsonProperty("restaurants")]

        public RestaurantRecord[] Restaurants { get; set; }
        public RestaurantList()
        {
            List<RestaurantList> restaurants = new List<RestaurantList>();
        }
    }
}
