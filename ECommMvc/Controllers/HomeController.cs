using ECommMvc.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ECommMvc.Controllers
{
    public class HomeController : Controller
    {
        //we can use HomeController(IDistributedCache)
        //but it will not have Redis rich data type apis; like INCR
        public IActionResult Index()
        {
            var cache = Startup.RedisConnection.GetDatabase();
            //await db.StringIncrementAsync("hitcounter");
            cache.StringIncrement("hitcounter");
            
            using (var db = new ECommContext())
            {
                var products = (from p in db.Products
                                where p.Rating > 3
                                select p).ToArray();
                this.ViewData["Products"] = products;
            }

            var counter = cache.StringGet("hitcounter");
            var visitors = cache.SetLength("visitor");

            this.ViewData["counter"] = counter;
            this.ViewData["visitors"] = visitors;
            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
