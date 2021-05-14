namespace BudgetAppModel
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImageUrl { get; set; }
        public System.DateTime CategoryCreationDate { get; set; }
        public System.DateTime CategoryUpdateDate { get; set; }
    }
}
