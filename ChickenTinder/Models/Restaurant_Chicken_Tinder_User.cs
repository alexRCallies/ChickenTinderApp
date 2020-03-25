﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenTinder.Models
{
    public class Restaurant_Chicken_Tinder_User
    {
        [ForeignKey("Chicken_Tinder_User")]
        public int Chicken_Tinder_UserId { get; set; }
        public Chicken_Tinder_User Chicken_Tinder_User { get; set; }
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}