using ChickenTinder.Data;
using ChickenTinder.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChickenTinder
{
    public class ZomatoInfo
    {
        private readonly ApplicationDbContext _context;
        private readonly ZomatoAPIClient _client;
        public ZomatoInfo(ApplicationDbContext context, ZomatoAPIClient client)
        {
            client = _client;
            context = _context;
        }
        
    }
}
