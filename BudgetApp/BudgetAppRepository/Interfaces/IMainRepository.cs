using System.Collections.Generic;

namespace BudgetAppRepository.Interfaces
{
    public interface IMainRepository<T> where T : class
    {
        void GetItems(int itemId, ref IEnumerable<T> listOfItems);
        void CreateItem(ref T item);
        void UpdateItem(ref T item);
        void DeleteItem(int itemId);
    }
}
