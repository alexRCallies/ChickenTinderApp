using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenTinder.Models
{
    public class Location
    {
        [Key]
        public int ID { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("city")]

        public string City { get; set; }
        [JsonProperty("latitude")]
        public string latitude { get; set; }
        [JsonProperty("longitude")]
        public string longitude { get; set; }

        [JsonProperty("locality_verbose")]

        public string LocalityVerbose { get; set; }
    }
}
