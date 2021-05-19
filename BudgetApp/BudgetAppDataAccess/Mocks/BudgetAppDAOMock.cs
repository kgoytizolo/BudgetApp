using BudgetAppDataAccess.Interface;
using BudgetAppModel;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace BudgetAppDataAccess.Mocks
{
    public class BudgetAppDAOMock<Item> : IBudgetAppDAO<Item> where Item : class
    {
        private Item _daoItem;

        public BudgetAppDAOMock(Item daoItem = default(Item))
        {
            _daoItem = daoItem;
        }

        public void CreateItem(ref Item item)
        {
            if (_daoItem.GetType() == typeof(Category)) item = GetCategory(9, false) as Item;
            return;
        }

        public void DeleteItem(int itemId)
        {
            return;
        }

        public void GetItems(int itemId, ref IEnumerable<Item> listOfItems)
        {
            if (_daoItem.GetType() == typeof(Category)) listOfItems = (IEnumerable<Item>)GetCategories(itemId);
            else return;
        }

        public void UpdateItem(ref Item item)
        {
            if (_daoItem.GetType() == typeof(Category)) {
                var categoryToUpdate = item as Category;
                item = GetCategory(categoryToUpdate.CategoryId, true) as Item;
            }
            return;
        }

        //************************ Internal Methods for Mock testing ********************************
        //1. Categories
        private IEnumerable<Category> GetCategories(int itemId)
        {   
            //Simulating DAO Categories
            DataSet dataSetCategory = new DataSet();
            SetupDataSet("Category Table", "Category", ref dataSetCategory);
            List<Category> categories = new List<Category>();
            for (int i = 0; i < dataSetCategory.Tables[0].Rows.Count; i++){
                var categoryTemp = new Category();
                categoryTemp.CategoryId = (int)dataSetCategory.Tables[0].Rows[i].ItemArray[0];
                categoryTemp.CategoryName = (string)dataSetCategory.Tables[0].Rows[i].ItemArray[1];
                categoryTemp.CategoryDescription = (string)dataSetCategory.Tables[0].Rows[i].ItemArray[2];
                categoryTemp.CategoryImageUrl = (string)dataSetCategory.Tables[0].Rows[i].ItemArray[3];
                categoryTemp.CategoryCreationDate = (DateTime)dataSetCategory.Tables[0].Rows[i].ItemArray[4];
                categoryTemp.CategoryUpdateDate = (DateTime)dataSetCategory.Tables[0].Rows[i].ItemArray[5];
                categories.Add(categoryTemp);
            }
            if (itemId > 0) return categories.Where(x => x.CategoryId == itemId);
            else return categories;
        }

        private Category GetCategory(int categoryId, bool updated) {
            return new Category() { 
                CategoryId = categoryId, 
                CategoryName = "New Category", 
                CategoryDescription = "All new category products may go here",
                CategoryImageUrl = "myNewCategory.jpg",
                CategoryCreationDate = DateTime.Now,
                CategoryUpdateDate = (updated) ? System.DateTime.Now : default(DateTime)
            };
        }

        //GENERIC SETUP
        private void SetupDataSet(string dataSetName, string dataSetTableName, ref DataSet newDataSet) 
        {
            newDataSet.DataSetName = dataSetName;
            DataTable newDataSetTable = new DataTable();                                    
            SetupTable(dataSetTableName, ref newDataSetTable);                              //Setting table + columns + rows
            newDataSet.Tables.Add(dataSetTableName);                                        //Final dataSet settings
        }

        private void SetupTable(string dataSetTable, ref DataTable newDataSetTable) 
        {
            SetupColumns(dataSetTable, ref newDataSetTable);
            SetupRows(dataSetTable, ref newDataSetTable);
        }

        private void SetupColumns(string dataSetTable, ref DataTable newDataSetTable) 
        {
            addColumns(new KeyValuePair<string, Type>[] {
                        new KeyValuePair<string, Type>("Id", typeof(int)),
                        new KeyValuePair<string, Type>("Name", typeof(string)),
                        new KeyValuePair<string, Type>("Description", typeof(string)),
                        new KeyValuePair<string, Type>("ImageUrl", typeof(string)),
                        new KeyValuePair<string, Type>("CreationDate", typeof(DateTime)),
                        new KeyValuePair<string, Type>("UpdateDate", typeof(DateTime))},
                0, ref newDataSetTable);

            switch (dataSetTable)   //To be used in customized columns
            {
                case "Category":
                    break;
            }
        }

        private void SetupRows(string dataSetTable, ref DataTable newDataSetTable) 
        {
            switch (dataSetTable)
            {
                case "Category":
                    AddRows(new object[] { 1, "Vegetables", "All vegetable products may go here", "myVeggies.jpg", DateTime.Now, default(DateTime)}, ref newDataSetTable);
                    AddRows(new object[] { 2, "Fruits", "All fruit products may go here", "myFruits.jpg", DateTime.Now, default(DateTime) }, ref newDataSetTable);
                    AddRows(new object[] { 3, "Meat", "All meat products may go here", "myMeats.jpg", DateTime.Now, default(DateTime) }, ref newDataSetTable);
                    AddRows(new object[] { 4, "Cleaning", "All cleaning products may go here", "myCleanings.jpg", DateTime.Now, default(DateTime) }, ref newDataSetTable);
                    AddRows(new object[] { 5, "Books", "All book products may go here", "myBooks.jpg", DateTime.Now, default(DateTime) }, ref newDataSetTable);
                    AddRows(new object[] { 6, "Toys", "All toy products may go here", "myToys.jpg", DateTime.Now, default(DateTime) }, ref newDataSetTable);
                    AddRows(new object[] { 7, "Restaurants", "All restaurants products may go here", "myRestaurants.jpg", DateTime.Now, default(DateTime) }, ref newDataSetTable);
                    AddRows(new object[] { 8, "Videogames", "All videogame products may go here", "myVideogames.jpg", DateTime.Now, default(DateTime) }, ref newDataSetTable);
                    break;
            }
        }

        private void addColumns(KeyValuePair<string, Type>[] arrColumns, int columnCounter, ref DataTable newDataSetTable) 
        {
            for (int i = columnCounter; i < arrColumns.Length; i++) {
                if (i == 0)
                {
                    DataColumn columnId = new DataColumn();
                    columnId = newDataSetTable.Columns.Add(arrColumns[i].Key, arrColumns[i].Value);
                    columnId.AllowDBNull = false;
                    columnId.Unique = true;
                }
                else {
                    string columnKey = arrColumns[i].Key;
                    var columnValue = arrColumns[i].Value;
                    newDataSetTable.Columns.Add(columnKey, columnValue);
                }
            }
        }

        private void AddRows(object[] item, ref DataTable newDataSetTable) 
        {
            for (int i = 0; i < newDataSetTable.Columns.Count; i++) 
            {
                if (newDataSetTable.Columns[i].DataType == typeof(string)) newDataSetTable.NewRow().ItemArray[i] = (string)item[i];
                else if (newDataSetTable.Columns[i].DataType == typeof(int)) newDataSetTable.NewRow().ItemArray[i] = (int)item[i];
                else if (newDataSetTable.Columns[i].DataType == typeof(DateTime)) newDataSetTable.NewRow().ItemArray[i] = (DateTime)item[i];
            }
        }

    }
}
