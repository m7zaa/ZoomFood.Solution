using Microsoft.AspNetCore.Mvc;
using ZoomFood.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ZoomFood.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly ZoomFoodContext _db;
        public RestaurantController(ZoomFoodContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Restaurant> model = _db.Restaurants.Include(restaurant => restaurant.Cuisine).ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
            return View(thisRestaurant);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
            _db.Restaurants.Remove(thisRestaurant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit (int id)
        {
            Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
            ViewBag.CuisineId = new SelectList (_db.Cuisines, "CuisineId", "Name");
            return View(thisRestaurant);
        }
        [HttpPost]
        public ActionResult Edit (Restaurant restaurant)
        {
            _db.Entry(restaurant).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("/Restaurant/Details/{id}")]
        public ActionResult Details(int id)
        {
            Restaurant thisRestaurant = _db.Restaurants.Include(restaurant => restaurant.Cuisine).Include(restaurant => restaurant.MenuItems).FirstOrDefault(restaurants => restaurants.RestaurantId == id);
            return View(thisRestaurant);
        }
    }
}