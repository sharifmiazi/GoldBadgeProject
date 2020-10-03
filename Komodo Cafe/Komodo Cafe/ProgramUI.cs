using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Cafe
{
    class ProgramUI
    {
        public void Run()
        {
            string buildNumber = "^5^";
            string author = "Sharif";

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("{0}    {1}", author, buildNumber);
            Console.ResetColor();

            Console.WriteLine("Hello and welcome to My Komodo Cafe! \n" +
                "Hit 'Enter' to enter the wonderful Food World!\n" +
                "<------------------------------------------------------------------>");
            Console.ReadLine();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                // Display Our Option
                Console.WriteLine("Select Menu option:\n" +
                    "1. Create a new Menu\n" +
                    "2. View all Menu\n" +
                    "3. Add Existing Menu\n" +
                    "4. Delete Existing Menu\n" +
                    "5. Exit");
                // Get User Input
                string input = Console.ReadLine();
                // Evaluate the users input and accordingly
                switch (input)
                {
                    case "1":
                        //Create new Menu
                        CreateNewMenu();
                        break;
                    case "2":
                        //View all Menu
                        DisplayAllMenu();
                        break;
                    case "3":
                        //Add Existing Menu
                        AddExistingMenu();
                        break;
                    case "4":
                        //Delete existing Menu
                        DeleteExistingMenu();
                        break;
                    case "5":
                        //  Exit
                        Console.WriteLine
                            ("Have A Good Day!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid Number.");
                        break;
                }
                Console.WriteLine("Please enter any key to Continue....");
                Console.ReadLine();
                Console.Clear();
            }
        }

        // Create a new Menu
        public void CreateNewMenu()
        {
         

            //MealName
            Console.WriteLine("Enter a Meal Name");
            string mealName = Console.ReadLine();

            //Mealumber
            Console.WriteLine("Enter a Meal Number'1,2,3,4'");
            int mealNumber = int.Parse(Console.ReadLine());

            //Description
            Console.WriteLine("Enter the Item Description");
            string description = Console.ReadLine();

            //ListOfIngrediants
            Console.WriteLine("Enter All the Ingreadiants");
            string ingrediants = Console.ReadLine();

            //Price
            Console.WriteLine("Enter The Menu Price: $$$");
            int price = int.Parse(Console.ReadLine());
        }
        // View all Menu
        private void DisplayAllMenu()
        {
            List<Menu> listofList = Menu_Repo.MenuList();
        }
        

        private void DisplayAllMenu( Menu list)
        {
            Console.WriteLine($"Menu Item #: {list.MealName}\n" +
                $"Menu Item Name: {list.MealNumber}\n" +
                $"Item Description: {list.Description}\n" +
                $"Item Ingredients: {list.ListOfIngredients}\n" +
                $"Item Price: ${list.Price}");
        }


        // Add existing Menu
        private void AddExistingMenu()
        {

        }
        // Delete Existing Menu
        private void DeleteExistingMenu()
        {
            DisplayAllMenu();
            Console.WriteLine("Select which item has to be delete?");
            string userInput = Console.ReadLine();
            bool deleted = Menu_Repo.RemoveMenuFromList();
            if (deleted)
            {
                Console.WriteLine("Menu item is deleted");
            }
            else
            {
                Console.WriteLine("Something went wrong, Try agin Please!!");
            }

        }
        public void SeedItemList()
        {
            Menu burger = new Menu("Bread,Lettuce,Beef Patties, Onion");
            Menu chickenNugget = new Menu("fried chicken, Cheese, onoin");

            Menu_Repo.AddMenuToList(burger);
            Menu_Repo.AddMenuToList(chickenNugget);
        }

        
        
    }

}
