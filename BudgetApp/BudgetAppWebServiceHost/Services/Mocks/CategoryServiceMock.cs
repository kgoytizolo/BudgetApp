using BudgetAppModel;
using BudgetAppWebServiceHost.Interfaces;
using GenericErrorHandler;
using System.Collections.Generic;

namespace BudgetAppWebServiceHost.Services.Mocks
{
    public class CategoryServiceMock : ICategoryService
    {
        public GenericErrorResponse AddCategory(Category category)
        {
            return new GenericErrorResponse();
        }

        public GenericErrorResponse DeleteCategory(int categoryId)
        {
            return new GenericErrorResponse();
        }

        public GenericErrorResponse<List<Category>> GetAllCategories()
        {
            return new GenericErrorResponse<List<Category>>
            {
                ResponseItem = new List<Category>(){
                    new Category { CategoryId = 1, CategoryName = "Vegetables", CategoryImageUrl = "myVeggies.jpg",
                                   CategoryDescription = "All vegetable products may go here", CategoryCreationDate = System.DateTime.Now },
                    new Category { CategoryId = 2, CategoryName = "Fruits", CategoryImageUrl = "myFruits.jpg" },
                    new Category { CategoryId = 3, CategoryName = "Meat", CategoryImageUrl = "myMeats.jpg" },
                    new Category { CategoryId = 4, CategoryName = "Meat", CategoryImageUrl = "myMeats.jpg" },
                    new Category { CategoryId = 5, CategoryName = "Cleaning", CategoryImageUrl = "myCleaning.jpg" },
                    new Category { CategoryId = 6, CategoryName = "Books", CategoryImageUrl = "myBooks.jpg" },
                    new Category { CategoryId = 7, CategoryName = "Toys", CategoryImageUrl = "myToys.jpg" },
                    new Category { CategoryId = 8, CategoryName = "Restaurants", CategoryImageUrl = "myToys.jpg" },
                }
            };
        }

        public GenericErrorResponse<Category> GetCategory(int categoryId)
        {
            return new GenericErrorResponse<Category>
            {
                ResponseItem = new Category
                {
                    CategoryId = categoryId,
                    CategoryName = "Vegetables",
                    CategoryImageUrl = "myVeggies.jpg",
                    CategoryDescription = "All vegetable products may go here",
                    CategoryCreationDate = System.DateTime.Now
                }
            };
        }

        public GenericErrorResponse UpdateCategory(Category category)
        {
            return new GenericErrorResponse();
        }
    }
}