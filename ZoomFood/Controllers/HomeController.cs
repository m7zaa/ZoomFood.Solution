using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZoomFood.Models;

namespace ZoomFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("/Privacy")]
        public ActionResult Privacy()
        {
            return View();
        }

        [HttpPost(Name ="Restaurant")]
        public ActionResult RestaurantSearch(string search)
        {
            return RedirectToAction("Index", "Restaurant", search);
        }
        // [HttpPost("/", Name ="Restaurant")]
        // public ActionResult RestaurantSearch(string search)
        // {
        //     return RedirectToAction("Index", "Restaurant", search);
        // }
    }
}
