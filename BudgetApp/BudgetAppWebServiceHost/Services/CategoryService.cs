using BudgetAppModel;
using BudgetAppWebServiceHost.Interfaces;
using GenericErrorHandler;
using System;
using System.Collections.Generic;

namespace BudgetAppWebServiceHost.Services
{
    public class CategoryService : ICategoryService
    {
        public GenericErrorResponse AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public GenericErrorResponse DeleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public GenericErrorResponse<List<Category>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public GenericErrorResponse<Category> GetCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public GenericErrorResponse UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}