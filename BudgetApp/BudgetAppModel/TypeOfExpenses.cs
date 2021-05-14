using System.ComponentModel;

namespace BudgetAppModel
{
    [System.Flags]
    public enum TypeOfExpenses
    {
        [Description("Type of expenses has not been selected - None")]
        None = 0b_0000_0000_0000_0000_0000,                          //None - 0
        [Description("Supermarket shopping")]
        Supermarket = 0b_0000_0000_0000_0000_0001,                   //Supermarket shopping - 1
        [Description("Market shopping")]
        Market = 0b_0000_0000_0000_0000_0010,                        //Market shopping - 2
        [Description("Online shopping")]
        OnlineShop = 0b_0000_0000_0000_0000_0100,                    //In case of buying online via Amazon, Ebay among others - 4
        [Description("Other kind of shopping")]
        OtherShop = 0b_0000_0000_0000_0000_1000,                     //Any additional local shop - 8
        [Description("Restaurants, bars and coffee shops")]
        RestaurantBarCoffee = 0b_0000_0000_0000_0001_0000,           //Any type of restaurants, bars and coffee shops goes here - 16
        [Description("Additional services")]
        Services = 0b_0000_0000_0000_0010_0000,                      //Extra services such as hairdressing, repair workshops among others - 32
        [Description("Healthcare")]
        Healthcare = 0b_0000_0000_0000_0100_0000,                    //Healthcare private expenses - 64
        [Description("Banking products to be paid")]
        BankPayments = 0b_0000_0000_0000_1000_0000,                  //Credit cards, loans among others - 128
        [Description("Government taxes")]
        Taxes = 0b_0000_0000_0001_0000_0000,                         //Government taxes - 256
        [Description("Electricity expenses")]
        Electricity = 0b_0000_0000_0010_0000_0000,                   //Household or company electricity - 512
        [Description("Gas expenses")]
        Gas = 0b_0000_0000_0100_0000_0000,                           //Household or company gas - 1024
        [Description("Water expenses")]
        Water = 0b_0000_0000_1000_0000_0000,                         //Household or company water - 2048
        [Description("Internet plan expenses")]
        Internet = 0b_0000_0001_0000_0000_0000,                      //Internet services - 4096
        [Description("Mobile plan expenses")]
        Mobile = 0b_0000_0010_0000_0000_0000,                        //Private mobile services - 8192
        [Description("Education expenses")]
        Education = 0b_0000_0100_0000_0000_0000,                     //Kindergarden, schools, colleges, universities, etc - 16384
        [Description("Other expenses")]
        Others = 0b_0000_1000_0000_0000_0000                         //Unclassified expenses goes here - 32768
    }
}
