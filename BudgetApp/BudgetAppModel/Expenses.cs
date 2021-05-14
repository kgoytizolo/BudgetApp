using System.Collections.Generic;

namespace BudgetAppModel
{
    public class Expenses
    {
        public int ExpenseId { get; set; }
        public System.DateTime ExpensesCreationDate { get; set; }
        public bool ReplicateFixedExpenses { get; set; }
        public List<ExpensesItem> ListOfExpensesPerPeriod { get; set; }     //Could be monthly, quarterly, etc.
        public decimal totalOfExpenses { get; set; }
    }
}
