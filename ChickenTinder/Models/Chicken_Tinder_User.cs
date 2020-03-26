using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenTinder.Models
{
    public class Chicken_Tinder_User
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int PhoneNumber { get; set; }
        [ForeignKey("Address")]
        public int? AddressId { get; set; }
        public Address Address { get; set; }
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        [ForeignKey("Restaurant")]
        public int? RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        [ForeignKey("Food_Type")]
        public int? Food_TypeId { get; set; }
        public Food_Type Food_Type { get; set; }
        public ICollection<Restaurant_Chicken_Tinder_User> Restaurant_Chicken_Tinder_Users { get; set; }
        public ICollection<Group_Chicken_Tinder_User> Group_Chicken_Tinder_Users { get; set; }
    }
}
