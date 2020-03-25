using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenTinder.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Group_Chicken_Tinder_User> Group_Chicken_Tinder_Users { get; set; }
        public ICollection<Group_Restaurant> Group_Restaurants { get; set; }
    }
}
