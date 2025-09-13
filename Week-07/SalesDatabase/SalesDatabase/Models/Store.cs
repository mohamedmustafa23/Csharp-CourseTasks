namespace SalesDatabase.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<Sale> Sales { get; set; } = new HashSet<Sale>();

    }

}

