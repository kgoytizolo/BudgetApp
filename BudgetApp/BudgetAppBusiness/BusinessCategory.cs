using BudgetAppBusiness.Interfaces;
using BudgetAppBusiness.ServiceGateway;
using BudgetAppModel;
using GenericErrorHandler;
using System.Collections.Generic;

namespace BudgetAppBusiness
{
    public class BusinessCategory : IBusinessCategory
    {
        private IServiceGatewayASMX _serviceGatewayASMX;                    //Calls every ASMX Services to be consumed by the client. ServiceGatewayASMX acts as a Gateway

        public BusinessCategory() {
            _serviceGatewayASMX = new ServiceGatewayASMX();
        }

        public GenericErrorResponse AddCategory(Category category)
        {
            return _serviceGatewayASMX.AddCategory(category);
        }

        public GenericErrorResponse DeleteCategory(int categoryId)
        {
            return _serviceGatewayASMX.DeleteCategory(categoryId);
        }

        public GenericErrorResponse<List<Category>> GetAllCategories()
        {
            return _serviceGatewayASMX.GetAllCategories();
        }

        public GenericErrorResponse<Category> GetCategory(int categoryId)
        {
            return _serviceGatewayASMX.GetCategory(categoryId);
        }

        public GenericErrorResponse UpdateCategory(Category category)
        {
            return _serviceGatewayASMX.UpdateCategory(category);
        }
    }
}
