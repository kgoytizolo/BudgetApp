using BudgetAppBusiness.Converters.ASMXServiceConverter.ItemConverter;
using BudgetAppBusiness.Converters.ASMXServiceConverter.Response;
using BudgetAppBusiness.Interfaces;
using BudgetAppModel;
using GenericErrorHandler;
using System.Collections.Generic;

namespace BudgetAppBusiness.ServiceGateway
{
    public class ServiceGatewayASMX : IServiceGatewayASMX
    {
        localhost.CategoryService _categoryProxy;                       //This app will consume any required ASMX service
        ICategoryConverter _categoryConverter;                          //This class will convert from native business classes to proxy and viceversa
        IResponseConverter<Category> _responseConverter;                //This class will convert from native business classes to proxy and viceversa

        public ServiceGatewayASMX() {
            _categoryProxy = new localhost.CategoryService();
            _categoryConverter = new CategoryConverter();
            _responseConverter = new ResponseConverter<Category>();
        }

        public GenericErrorResponse AddCategory(Category category)
        {
            localhost.Category categoryRequest = _categoryConverter.ConvertCategoryForASMXService(category);
            localhost.GenericErrorResponse serviceResponseAsmx = _categoryProxy.AddCategory(categoryRequest);
            return _responseConverter.ConvertServiceResponse(serviceResponseAsmx);
        }

        public GenericErrorResponse DeleteCategory(int categoryId)
        {
            localhost.GenericErrorResponse serviceResponseAsmx = _categoryProxy.DeleteCategory(categoryId);
            return _responseConverter.ConvertServiceResponse(serviceResponseAsmx);
        }

        public GenericErrorResponse<List<Category>> GetAllCategories()
        {
            var listOfCategoriesResponse = _categoryProxy.GetAllCategories();
            return _responseConverter.ConvertServiceResponseItem(listOfCategoriesResponse);
        }

        public GenericErrorResponse<Category> GetCategory(int categoryId)
        {
            var categoryResponse = _categoryProxy.GetCategory(categoryId);
            return _responseConverter.ConvertServiceResponseItem(categoryResponse);
        }

        public GenericErrorResponse UpdateCategory(Category category)
        {
            localhost.Category categoryRequest = _categoryConverter.ConvertCategoryForASMXService(category);
            localhost.GenericErrorResponse serviceResponseAsmx = _categoryProxy.UpdateCategory(categoryRequest);
            return _responseConverter.ConvertServiceResponse(serviceResponseAsmx);
        }
    }
}
