using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenTinder.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Food_Type")]
        public int? FoodTypeId { get; set; }
        public Food_Type Food_Type { get; set; }
        [ForeignKey("Address")]
        public int? AddressId { get; set; }
        public Address Address { get; set; }
        public ICollection<Group_Restaurant> Group_Restaurants { get; set; }
        public ICollection<Restaurant_Chicken_Tinder_User> Restaurant_Chicken_Tinder_Users { get; set; }
    }
}

