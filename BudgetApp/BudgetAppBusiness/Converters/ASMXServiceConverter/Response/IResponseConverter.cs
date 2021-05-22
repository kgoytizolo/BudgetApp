using BudgetAppModel;
using GenericErrorHandler;
using System.Collections.Generic;

namespace BudgetAppBusiness.Converters.ASMXServiceConverter.Response
{
    public interface IResponseConverter<T> where T : class
    {
        GenericErrorResponse ConvertServiceResponse(localhost.GenericErrorResponse asmxServiceResponse);
        GenericErrorResponse<List<Category>> ConvertServiceResponseItem(localhost.GenericErrorResponseOfListOfCategory asmxServiceResponse);
        GenericErrorResponse<Category> ConvertServiceResponseItem(localhost.GenericErrorResponseOfCategory asmxServiceResponse);
        localhost.GenericErrorResponse ConvertServiceResponseForASMX(GenericErrorResponse serviceResponse);
    }
}
