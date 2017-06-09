using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using IMDBPullAPI.Core;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace IMDBPullAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            GetAPICall();

            return View();
        }

        public async void GetAPICall()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://www.imdb.com/xml/find?json=1&nr=1&tt=on&q=lost");
                if(response.IsSuccessStatusCode)
                {
                    var doc = JsonConvert.DeserializeObject<TitleInformation>(response.Content.ReadAsStringAsync().Result);
                }
            }
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
