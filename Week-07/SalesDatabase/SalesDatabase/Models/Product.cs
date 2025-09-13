namespace SalesDatabase.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = "No description";

        public ICollection<Sale> Sales { get; set; } = new HashSet<Sale>();
    }
}
