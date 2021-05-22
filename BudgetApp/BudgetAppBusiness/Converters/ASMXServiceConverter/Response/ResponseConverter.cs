using GenericErrorHandler;
using BudgetAppModel;
using System.Collections.Generic;
using BudgetAppBusiness.Converters.ASMXServiceConverter.ItemConverter;
using System.Linq;

namespace BudgetAppBusiness.Converters.ASMXServiceConverter.Response
{
    public class ResponseConverter<T> : IResponseConverter<T> where T: class
    {
        private ICategoryConverter _categoryConverter;

        public ResponseConverter() {
            _categoryConverter = new CategoryConverter();
        }

        public GenericErrorResponse ConvertServiceResponse(localhost.GenericErrorResponse asmxServiceResponse)
        {
            if (asmxServiceResponse == null) return null;
            return new GenericErrorResponse 
            {
                ErrorId = asmxServiceResponse.ErrorId,
                ErrorMessage = asmxServiceResponse.ErrorMessage,
                ErrorTracking = asmxServiceResponse.ErrorTracking
            };
        }

        public localhost.GenericErrorResponse ConvertServiceResponseForASMX(GenericErrorResponse serviceResponse)
        {
            if (serviceResponse == null) return null;
            return new localhost.GenericErrorResponse 
            {
                ErrorId = serviceResponse.ErrorId,
                ErrorMessage = serviceResponse.ErrorMessage,
                ErrorTracking = serviceResponse.ErrorTracking
            };
        }

        public GenericErrorResponse<List<Category>> ConvertServiceResponseItem(localhost.GenericErrorResponseOfListOfCategory asmxServiceResponse)
        {
            var serviceResponse = new GenericErrorResponse<List<Category>>();
            if (asmxServiceResponse == null) serviceResponse.SetErrorInfo(9998, "There is no service response data provided to convert in this application.");
            else
            {
                if (asmxServiceResponse.ResponseItem == null) serviceResponse.SetErrorInfo(9999, "There are no categories to show in this application.");
                else 
                {
                    List<Category> listOfCategories = _categoryConverter.ConvertListOfCategories(asmxServiceResponse.ResponseItem.ToList());
                    serviceResponse.SetErrorInfo(asmxServiceResponse.ErrorId, asmxServiceResponse.ErrorMessage, asmxServiceResponse.ErrorTracking);
                    serviceResponse.ResponseItem = listOfCategories;
                    return serviceResponse;
                }
            }
            return serviceResponse;
        }

        public GenericErrorResponse<Category> ConvertServiceResponseItem(localhost.GenericErrorResponseOfCategory asmxServiceResponse)
        {
            var serviceResponse = new GenericErrorResponse<Category>();
            if (asmxServiceResponse == null) serviceResponse.SetErrorInfo(9998, "There is no service response data provided to convert in this application.");
            else {
                if (asmxServiceResponse.ResponseItem == null) serviceResponse.SetErrorInfo(9997, "There is no category to show in this application.");
                else 
                {
                    Category category = _categoryConverter.ConvertCategory(asmxServiceResponse.ResponseItem);
                    serviceResponse.SetErrorInfo(asmxServiceResponse.ErrorId, asmxServiceResponse.ErrorMessage, asmxServiceResponse.ErrorTracking);
                    serviceResponse.ResponseItem = category;
                }
            }
            return serviceResponse;
        }
    }
}
