namespace PizzAPI.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<string>? Ingredients { get; set; }
        public bool IsGlutenFree { get; set; }

    }
}