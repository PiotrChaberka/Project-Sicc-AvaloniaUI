namespace Project_SICC.Data
{
    public class Product
    {
        public int ID { get; set; }
        public string Company { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public decimal SuggestedPrice { get; set; }
        public string? Comment { get; set; } // Nullable
    }
}