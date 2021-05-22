using BudgetAppModel;
using System.Collections.Generic;

namespace BudgetAppBusiness.Converters.ASMXServiceConverter.ItemConverter
{
    public interface ICategoryConverter
    {
        Category ConvertCategory(localhost.Category categoryForService);
        localhost.Category ConvertCategoryForASMXService(Category category);
        List<Category> ConvertListOfCategories(List<localhost.Category> listOfServiceCategories);
    }
}
