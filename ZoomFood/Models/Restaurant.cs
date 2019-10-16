using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ZoomFood.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public int PriceRating { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        [Required]
        public int CuisineId { get; set; }
        
        [ForeignKey("CuisineId")]
        public virtual Cuisine Cuisine { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }

        public Restaurant()
        {
            this.MenuItems = new HashSet<MenuItem>();
        }
    }
}