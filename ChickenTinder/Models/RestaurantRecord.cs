using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenTinder.Models
{
    public class RestaurantRecord
    {
        [JsonProperty("restaurant")]

        public Restaurant Restaurant { get; set; }
    }
}
