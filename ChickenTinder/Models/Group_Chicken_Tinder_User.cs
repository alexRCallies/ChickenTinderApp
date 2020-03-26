using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenTinder.Models
{
    public class Group_Chicken_Tinder_User
    {
        [Key, Column(Order =0)]
        public int GroupId { get; set; }
        [Key, Column(Order = 1)]
        public int Chicken_Tinder_UserId { get; set; }
    }
}
