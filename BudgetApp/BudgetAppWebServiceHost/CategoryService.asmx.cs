using System.Collections.Generic;
using System.Web.Services;
using BudgetAppModel;
using GenericErrorHandler;

namespace BudgetAppWebServiceHost
{
    /// <summary>
    /// This ASMX endpoint will allow to get many Categories methods to be consumed by several applications
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class CategoryService : System.Web.Services.WebService
    {
        /// <summary>
        /// This service will return all detailed information about the category
        /// </summary>
        /// <param name="categoryId">This is the category Id required for the category search</param>
        /// <returns>The requested category information. In case that nothing has been found, the Category will return null with the response error</returns>
        [WebMethod]
        public GenericErrorResponse<Category> GetCategory(int categoryId)
        {
            return new GenericErrorResponse<Category> { 
                ResponseItem = new Category {
                    CategoryId = categoryId,
                    CategoryName = "Vegetables",
                    CategoryImageUrl = "myVeggies.jpg",
                    CategoryDescription = "All vegetable products may go here",
                    CategoryCreationDate = System.DateTime.Now
                }
            };
        }

        /// <summary>
        /// This service will return a list of all Categories required by the budget App, in order to define the product item
        /// </summary>
        /// <returns>A list of all the categories to be selected by the client, in order to clasify the expenses. 
        /// In case that nothing has been found, the Category List will return null with the corresponding response error</returns>
        [WebMethod]
        public GenericErrorResponse<List<Category>> GetAllCategories() 
        {
            return new GenericErrorResponse<List<Category>> {
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

        /// <summary>
        /// This service will allow the client to add any other category for a customized budget tracking.
        /// </summary>
        /// <param name="category">The new category to be added</param>
        /// <returns>
        /// 0 = Adding result was sucessful
        /// > 0 = Adding result had errors.
        /// </returns>
        [WebMethod]
        public GenericErrorResponse AddCategory(Category category)
        {
            return new GenericErrorResponse();
        }

        /// <summary>
        /// This service will allow the client to update an existing category for a customized budget tracking.
        /// </summary>
        /// <param name="category">The existing category to be updated (Based on the category ID)</param>
        /// <returns>
        /// 0 = Update result was sucessful
        /// > 0 = Update result had errors.
        /// </returns>
        [WebMethod]
        public GenericErrorResponse UpdateCategory(Category category) 
        {
            return new GenericErrorResponse();
        }

        /// <summary>
        /// This service will allow the client to delete an existing category for a customized budget tracking.
        /// </summary>
        /// <param name="categoryId">The existing category to be deleted (Based on the category ID)</param>
        /// <returns>
        /// 0 = Delete result was sucessful
        /// >0 = Delete result had errors.
        /// </returns>
        [WebMethod]
        public GenericErrorResponse DeleteCategory(int categoryId)
        {
            return new GenericErrorResponse();
        }

    }
}
