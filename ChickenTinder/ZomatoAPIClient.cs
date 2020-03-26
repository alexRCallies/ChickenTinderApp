using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChickenTinder
{
    public class ZomatoAPIClient
    {
        public ZomatoAPIClient(HttpClient client)
        {
            Client = client;
        }
        public HttpClient Client { get; set; }
    }
}
