using GenericErrorHandler;
using BudgetAppModel;
using System.Collections.Generic;

namespace BudgetAppBusiness.Interfaces
{
    public interface IServiceGatewayASMX
    {
        GenericErrorResponse<Category> GetCategory(int categoryId);
        GenericErrorResponse<List<Category>> GetAllCategories();
        GenericErrorResponse AddCategory(Category category);
        GenericErrorResponse UpdateCategory(Category category);
        GenericErrorResponse DeleteCategory(int categoryId);
    }
}
