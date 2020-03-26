using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenTinder.Models
{
    public class Restaurant
    {
        [JsonProperty("id")]

        public int ID { get; set; }



        [JsonProperty("name")]

        public string Name { get; set; }



        [JsonProperty("location")]
        [ForeignKey("Location")]
        public int LocationID { get; set; }
        public Location Location { get; set; }

        [JsonProperty("cuisines")]

        public string Cuisines { get; set; }



        [JsonProperty("average_cost_for_two")]

        public int AverageCostForTwo { get; set; }



        [JsonProperty("currency")]

        public string Currency { get; set; }
        public ICollection<Group_Restaurant> Group_Restaurants { get; set; }
        public ICollection<Restaurant_Chicken_Tinder_User> Restaurant_Chicken_Tinder_Users { get; set; }
    }
}
