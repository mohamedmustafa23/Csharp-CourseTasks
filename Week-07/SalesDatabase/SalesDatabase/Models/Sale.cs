namespace SalesDatabase.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime Date { get; set; } 
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public Product Product { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
        public Store Store { get; set; } = null!;
    }
}
