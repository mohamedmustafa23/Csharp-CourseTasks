namespace SalesDatabase.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CreditCardNumber { get; set; } = string.Empty;
        public ICollection<Sale> Sales { get; set; } = new HashSet<Sale>();
    }
}
