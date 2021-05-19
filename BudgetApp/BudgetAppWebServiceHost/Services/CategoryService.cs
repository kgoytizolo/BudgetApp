using BudgetAppModel;
using BudgetAppRepository;
using BudgetAppWebServiceHost.Interfaces;
using GenericErrorHandler;
using System;
using System.Collections.Generic;

namespace BudgetAppWebServiceHost.Services
{
    public class CategoryService : ICategoryService
    {
        private MainRepository<Category> _mainRepository;

        public CategoryService()
        {
            _mainRepository = new MainRepository<Category>();
        }

        public GenericErrorResponse AddCategory(Category category)
        {
            var serviceResponse = new GenericErrorResponse(); 
            try {
                _mainRepository.CreateItem(ref category);
            }
            catch (Exception e) {
                serviceResponse.SetErrorInfo(e.HResult, e.Message, e.StackTrace);
            }
            return serviceResponse;
        }

        public GenericErrorResponse DeleteCategory(int categoryId)
        {
            var serviceResponse = new GenericErrorResponse();
            try
            {
                _mainRepository.DeleteItem(categoryId);
            }
            catch (Exception e)
            {
                serviceResponse.SetErrorInfo(e.HResult, e.Message, e.StackTrace);
            }
            return serviceResponse;
        }

        public GenericErrorResponse<List<Category>> GetAllCategories()
        {
            var serviceResponse = new GenericErrorResponse<List<Category>>();
            try
            {
                IEnumerable<Category> listOfCategories = new List<Category>();
                _mainRepository.GetItems(0, ref listOfCategories);
            }
            catch (Exception e)
            {
                serviceResponse.SetErrorInfo(e.HResult, e.Message, e.StackTrace);
            }
            return serviceResponse;
        }

        public GenericErrorResponse<Category> GetCategory(int categoryId)
        {
            var serviceResponse = new GenericErrorResponse<Category>();
            try
            {
                IEnumerable<Category> listOfCategories = new List<Category>();
                _mainRepository.GetItems(0, ref listOfCategories);
                var listTemp = listOfCategories as List<Category>;
                serviceResponse.ResponseItem = listTemp[0];
            }
            catch (Exception e)
            {
                serviceResponse.SetErrorInfo(e.HResult, e.Message, e.StackTrace);
            }
            return serviceResponse;
        }

        public GenericErrorResponse UpdateCategory(Category category)
        {
            var serviceResponse = new GenericErrorResponse();
            try
            {
                _mainRepository.UpdateItem(ref category);
            }
            catch (Exception e)
            {
                serviceResponse.SetErrorInfo(e.HResult, e.Message, e.StackTrace);
            }
            return serviceResponse;
        }
    }
}