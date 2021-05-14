namespace BudgetAppModel
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImageUrl { get; set; }
        public Category Category { get; set; }
        public System.DateTime ProductCreationDate { get; set; }
        public System.DateTime ProductUpdateDate { get; set; }
    }
}
