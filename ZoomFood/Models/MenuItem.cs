namespace ZoomFood.Models
{
    public class MenuItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsVegan { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsOrganic { get; set; }
        public bool HasGMOs { get; set; }
        public int Calories { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}