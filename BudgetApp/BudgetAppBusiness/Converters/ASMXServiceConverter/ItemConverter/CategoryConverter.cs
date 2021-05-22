using BudgetAppModel;
using System.Collections.Generic;

namespace BudgetAppBusiness.Converters.ASMXServiceConverter.ItemConverter
{
    public class CategoryConverter : ICategoryConverter
    {
        public Category ConvertCategory(localhost.Category categoryForService)
        {
            if (categoryForService == null) return null;
            return new Category
            {
                CategoryId = categoryForService.CategoryId,
                CategoryName = categoryForService.CategoryName ?? "",
                CategoryDescription = categoryForService.CategoryDescription ?? "",
                CategoryImageUrl = categoryForService.CategoryImageUrl ?? "",
                CategoryCreationDate = categoryForService.CategoryCreationDate,
                CategoryUpdateDate = categoryForService.CategoryUpdateDate
            };
        }

        public localhost.Category ConvertCategoryForASMXService(Category category)
        {
            if (category == null) return null;
            return new localhost.Category
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName ?? "",
                CategoryDescription = category.CategoryDescription ?? "",
                CategoryImageUrl = category.CategoryImageUrl ?? "",
                CategoryCreationDate = category.CategoryCreationDate,
                CategoryUpdateDate = category.CategoryUpdateDate
            };
        }

        public List<Category> ConvertListOfCategories(List<localhost.Category> listOfServiceCategories)
        {
            if (listOfServiceCategories == null) return null;
            else {
                List<Category> listOfCategories = new List<Category>();
                listOfServiceCategories.ForEach(c => listOfCategories.Add(ConvertCategory(c)));
                return listOfCategories;
            }
        }
    }
}
