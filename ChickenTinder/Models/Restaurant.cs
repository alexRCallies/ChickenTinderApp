using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenTinder.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Address { get; set; }
        [ForeignKey("Food_Type")]
        public int Food_TypeId { get; set; }
        public Food_Type Food_Type { get; set; }
       public ICollection<Restaurant_Chicken_Tinder_User> Restaurant_Chicken_Tinder_Users { get; set; }
        public ICollection<Group_Restaurant> Group_Restaurants { get; set; }

    }
}
