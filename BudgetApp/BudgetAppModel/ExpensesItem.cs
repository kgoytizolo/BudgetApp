namespace BudgetAppModel
{
    public class ExpensesItem
    {
        public int ExpensesItemId { get; set; }
        public string ExpensesItemName { get; set; }
        public string ExpensesItemPurpose { get; set; }
        public bool IsVariableOrFixedExpense { get; set; }
        public string ExpensesItemImageUrl { get; set; }
        public Product Product { get; set; }
        public double ExpensesItemUnitPrice { get; set; }
        public int ExpensesItemQuantity { get; set; }
        public double ExpensesItemTotal { get; set; }
        public TypeOfExpenses TypeOfExpenses { get; set; }
        public System.DateTime ExpensesItemCreationDate { get; set; }
        public System.DateTime ExpensesItemUpdateDate { get; set; }
    }
}
