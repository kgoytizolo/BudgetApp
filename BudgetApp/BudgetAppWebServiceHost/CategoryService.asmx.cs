using System.Collections.Generic;
using System.Web.Services;
using BudgetAppModel;
using BudgetAppWebServiceHost.Services.Mocks;
using GenericErrorHandler;
using catService = BudgetAppWebServiceHost.Services;

namespace BudgetAppWebServiceHost
{
    /// <summary>
    /// This ASMX endpoint will allow to get many Categories methods to be consumed by several applications
    /// </summary>
    [WebService(Namespace = "http://keynimeSolutions.io/services")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class CategoryService : WebService
    {
        //CategoryServiceMock _categoryService;
        catService.CategoryService _categoryService;

        public CategoryService() 
        {
            //_categoryService = new CategoryServiceMock();
            _categoryService = new catService.CategoryService();
        }

        /// <summary>
        /// This service will return all detailed information about the category
        /// </summary>
        /// <param name="categoryId">This is the category Id required for the category search</param>
        /// <returns>The requested category information. In case that nothing has been found, the Category will return null with the response error</returns>
        [WebMethod]
        public GenericErrorResponse<Category> GetCategory(int categoryId)
        {
            return _categoryService.GetCategory(categoryId);
        }

        /// <summary>
        /// This service will return a list of all Categories required by the budget App, in order to define the product item
        /// </summary>
        /// <returns>A list of all the categories to be selected by the client, in order to clasify the expenses. 
        /// In case that nothing has been found, the Category List will return null with the corresponding response error</returns>
        [WebMethod]
        public GenericErrorResponse<List<Category>> GetAllCategories() 
        {
            return _categoryService.GetAllCategories();
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
            return _categoryService.AddCategory(category);
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
            return _categoryService.UpdateCategory(category);
        }

        /// <summary>
        /// This service will allow the client to delete an existing category for a customized budget tracking.
        /// </summary>
        /// <param name="categoryId">The existing category to be deleted (Based on the category ID)</param>
        /// <returns>
        /// 0 = Delete result was sucessful
        /// > 0 = Delete result had errors.
        /// </returns>
        [WebMethod]
        public GenericErrorResponse DeleteCategory(int categoryId)
        {
            return _categoryService.DeleteCategory(categoryId);
        }

    }
}
