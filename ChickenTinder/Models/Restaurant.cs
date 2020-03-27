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
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [ForeignKey("Location")]
        public int? LocationID { get; set; }
        [JsonProperty("location")]
        public Location Location { get; set; }
        [JsonProperty("cuisines")]
        public string Cuisines { get; set; }



        [JsonProperty("average_cost_for_two")]
        public int AverageCostForTwo { get; set; }



        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
