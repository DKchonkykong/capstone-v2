//not working atm but it's supposed to hold the main menu logic
namespace Capstone_v2;

 internal class MainMenu : ConsoleMenu
{
    //constructor
    private FoodManager _manager;
    //constructor
    public MainMenu(FoodManager manager)
    {
        _manager = manager;
    }
    public override void CreateMenu()
        //this is how it will most likely look for displaying menus pretty similar to how i have done it before
    // for some reason this doesn't show up correctly
    //some code here might be changed 
    {
        _menuItems.Clear();
        _menuItems.Add(new MainMenuItem.AddNewOrderMenuItem(_manager));
        _menuItems.Add(new MainMenuItem.AddNewFoodMenuItem(_manager));
        _menuItems.Add(new MainMenuItem.DisplayAllOrderMenu(_manager));
        _menuItems.Add(new MainMenuItem.DisplayAllFoodMenuItem(_manager));
        _menuItems.Add(new ExitMenuItem(this));
    }
    public override string MenuText()
    {
        return "restaurant test";
    }
}
   
