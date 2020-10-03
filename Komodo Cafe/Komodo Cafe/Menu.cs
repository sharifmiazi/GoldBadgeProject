using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Cafe
{

    public class Menu
    {
        public string MealName { get; set; }
        public int MealNumber { get; set; }
        public string Description { get; set; }
        public string ListOfIngredients { get; set; }
        public int Price { get; set; }
        public Menu() { }
        public Menu(string mealName, int mealNumber, string description, string listOfIngredients, int price)
        {
            MealName = mealName;
            MealNumber = mealNumber;
            Description = description;
            ListOfIngredients = listOfIngredients;
            Price = price;

         }
    }
}
