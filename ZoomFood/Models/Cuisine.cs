using System.Collections.Generic;

namespace ZoomFood.Models
{
    public class Cuisine
    {
        public Cuisine()
        {
            this.Restaurants = new HashSet<Restaurant>();
        }
        
        public int CuisineId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }

    }
}