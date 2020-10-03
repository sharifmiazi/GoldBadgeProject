using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Cafe
{
    public class Menu_Repo
    {
        private List<Menu_Repo> _listOfMenu = new List<Menu_Repo>();
        // Create
        public void AddMenuToList(Menu_Repo food)
        {
            _listOfMenu.Add(food);
        }
        // Read
        public List<Menu_Repo> GetMenuList()
        {
            return _listOfMenu;
        }
        //Get meal by Number
        public Menu GetItemByNumber(string mealNumber)
        {
            foreach (Menu item in _listOfMenu)
            {
                if (item.MealNumber.ToLower() == mealNumber.ToLower())
                {
                    return item;
                }
            }
            return null;
        }
        // Update
        public bool UpdateExistingItem(Menu updatedItem, string orginalName)
        {
            Menu list = GetItemByNumber(orginalName);
            if(list != null)
            {
                int itemIndex = _listOfMenu.IndexOf(list);
                _listOfMenu[itemIndex] = updatedItem;
                return true;
            }
            return false;
        }
        // Delete
       public bool RemoveMenuFromList(string mealName)
        {
            Menu item = GetItemByNumber(mealName);
            
            if (item == null)
            {
                return false;
            }
            int initialMealNumber = _listOfMenu.Count;
            _listOfMenu.Remove(item);

            if (initialMealNumber > _listOfMenu.Count)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
       
        
    }
}
