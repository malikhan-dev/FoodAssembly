namespace FoodAssembly.Models
{
    public abstract class BaseCategoryDto
    {
        public required string Name { get; set; }
        public required string IconUrl { get; set; }
    }
}
