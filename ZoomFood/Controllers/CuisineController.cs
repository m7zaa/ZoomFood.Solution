using Microsoft.AspNetCore.Mvc;
using ZoomFood.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ZoomFood.Controllers
{
    public class CuisineController : Controller
    {
        private readonly ZoomFoodContext _db;
        public CuisineController(ZoomFoodContext db)
        {
            _db = db;
        }

        public ActionResult Index ()
        {
            List<Cuisine> model = _db.Cuisines.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create( Cuisine cuisine)
        {
            _db.Cuisines.Add(cuisine);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
            return View(thisCuisine);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
            _db.Cuisines.Remove(thisCuisine);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}