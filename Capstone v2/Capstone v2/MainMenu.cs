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
    
    //this is how it will most likely look for displaying menus pretty similar to how i have done it before
    // for some reason this doesn't show up correctly
    //some code here might be changed 
    //got two errors now both being about the order items idk how to make them go away?
    //Possible fix: 1.make it so order Ieunumerable is in foodmanager have it be like it was before...
    //2.There should be a way to have it so there's still manager but also order in there as well
    //3. _manager.OrderMenus has still got stuff related to the order list and _manager has the values of foods name etc. Do we need to have it in order for it to still function?
    //I think i should probably not change as much as I can, doesn't work atm though
    public override void CreateMenu()
   
    {
        _menuItems.Clear();
        //_menuItems.Add(new Order.AddNewOrderMenuItem(_manager));
        _menuItems.Add(new MainMenuItem.AddNewFoodMenuItem(_manager));
        _menuItems.Add(new Order.DisplayAllOrderMenu(_manager));
        _menuItems.Add(new MainMenuItem.DisplayAllFoodMenuItem(_manager));
        _menuItems.Add(new ExitMenuItem(this));
    }
    public override string MenuText()
    {
        return "restaurant test";
    }
}
   
