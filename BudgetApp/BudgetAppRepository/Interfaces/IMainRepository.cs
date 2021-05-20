using System.Collections.Generic;

namespace BudgetAppRepository.Interfaces
{
    public interface IMainRepository<T> where T : class
    {
        void GetItems(int itemId, ref IEnumerable<T> listOfItems);
        void CreateItem(T item);
        void UpdateItem(T item);
        void DeleteItem(int itemId);
    }
}
