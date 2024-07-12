//not working atm but it's supposed to hold the main menu logic
namespace Capstone_v2;

public class MainMenu : ConsoleMenu
{
    //constructor and stuff here 
    private FoodManager _manager;
    //constructor
    public MainMenu(FoodManager manager)
    {
        _manager = manager;
    }
    public override void CreateMenu()
        //this is how it will most likely look for displaying menus pretty similar to how i have done it before
    {
        _menuItems.Clear();
        _menuItems.Add(new AddNewFoodMenuItem(_manager));
        _menuItems.Add(new AddNewOrderMenuItem(_manager));
        _menuItems.Add(new DisplayAllOrderMenu(_manager.OrderMenus));
        _menuItems.Add(new DisplayAllFoodMenuItem(_manager.Foods));
        _menuItems.Add(new ExitMenuItem(this));
    }
    public override string MenuText()
    {
        return "Cruise2Holiday Admin Menu\n";
    }
}
   
