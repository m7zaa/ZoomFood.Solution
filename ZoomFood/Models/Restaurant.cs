using System.Collections.Generic;

namespace ZoomFood.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public int PriceRating { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public virtual ICollection<MenuItem> MenuItems { get; set; }

        public Restaurant()
        {
            this.MenuItems = new HashSet<MenuItem>();
        }
    }
}