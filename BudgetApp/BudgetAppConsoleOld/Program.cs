using static System.Console;
using BudgetAppModel;
using GenericErrorHandler;
using BudgetAppBusiness;
using System.Collections.Generic;

namespace BudgetAppConsoleOld
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to the Budget App (Console version)!");
            WriteLine();
            WriteLine("This console app uses .NET 5 and calls a common business client layer which uses .NET Standard 2.0");
            WriteLine("The purpose of using .NET Standard 2.0 is in order to make the code compatible with older .NET Framework libraries");
            WriteLine();
            WriteLine("------------- Getting categories through ASMX Services: -------------");
            BusinessCategory myCategories = new BusinessCategory();                                     //Then, we are going to implement IOC and DI later
            GenericErrorResponse<List<Category>> serviceResponse = myCategories.GetAllCategories();     //We get all the categories here
            if (serviceResponse.ErrorId > 0) serviceResponse.ShowErrorMessageInConsole();
            else
            {
                var listOfCategories = serviceResponse.ResponseItem;
                listOfCategories.ForEach(cat => WriteLine($"Category: Id = {cat.CategoryId}, Name = {cat.CategoryName}, Description = {cat.CategoryDescription} "));
            };
            WriteLine();
            WriteLine("Press any key to exit...");
            string continueToNextAction = ReadLine();
        }
    }
}
