using BudgetAppDataAccess.Interface;
using System;
using System.Collections.Generic;

namespace BudgetAppDataAccess
{
    public class BudgetAppDAO<Item> : IBudgetAppDAO<Item> where Item : class
    {
        private Item _daoItem;

        public BudgetAppDAO(Item daoItem = default(Item)) 
        {
            _daoItem = daoItem;
        }

        public void CreateItem(ref Item item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(int itemId)
        {
            throw new NotImplementedException();
        }

        public void GetItems(int itemId, ref IEnumerable<Item> input)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(ref Item item)
        {
            throw new NotImplementedException();
        }
    }
}
