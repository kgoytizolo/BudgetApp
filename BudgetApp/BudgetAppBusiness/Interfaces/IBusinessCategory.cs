using BudgetAppModel;
using GenericErrorHandler;
using System.Collections.Generic;

namespace BudgetAppBusiness.Interfaces
{
    public interface IBusinessCategory
    {
        GenericErrorResponse<Category> GetCategory(int categoryId);
        GenericErrorResponse<List<Category>> GetAllCategories();
        GenericErrorResponse AddCategory(Category category);
        GenericErrorResponse UpdateCategory(Category category);
        GenericErrorResponse DeleteCategory(int categoryId);
    }
}
