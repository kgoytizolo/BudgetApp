using BudgetAppDataAccess.Mocks;
using BudgetAppRepository.Interfaces;
using System.Collections.Generic;

namespace BudgetAppRepository
{
    public class MainRepository<T> : IMainRepository<T> where T : class
    {
        private T _repositoryItem;
        private BudgetAppDAOMock<T> _budgetAppDao;

        public MainRepository(T repositoryItem = default(T))
        {
            _repositoryItem = repositoryItem;
            _budgetAppDao = new BudgetAppDAOMock<T>(_repositoryItem);
        }

        public void CreateItem(T item)
        {
            _budgetAppDao.CreateItem(item);
        }

        public void DeleteItem(int itemId)
        {
            _budgetAppDao.DeleteItem(itemId);
        }

        public void GetItems(int itemId, ref IEnumerable<T> listOfItems)
        {
            _budgetAppDao.GetItems(itemId, ref listOfItems);
        }

        public void UpdateItem(T item)
        {
            _budgetAppDao.UpdateItem(item);
        }
    }
}
