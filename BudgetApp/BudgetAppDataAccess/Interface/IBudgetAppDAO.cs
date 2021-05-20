using System.Collections.Generic;

namespace BudgetAppDataAccess.Interface
{
    public interface IBudgetAppDAO<Item> where Item : class
    {
        void GetItems(int itemId, ref IEnumerable<Item> input);
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(int itemId);
    }
}
