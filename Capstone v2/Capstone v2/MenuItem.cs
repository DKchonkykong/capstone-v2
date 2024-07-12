namespace Capstone_v2;
//this is a class that is supposed to be a sub menu think of how there was 
public class MenuItem
{
    //psuedo code
    //unsure if need to have this: could be needed for adding specific values
    //but i don't think i need this 
    // public void RunAction(object[] parameters)
    //{
        //_action.DynamicInvoke(parameters);
    //}
    
    
    //What most likely I will need here as individual classes: 
    //AddNewFoodMenuItem
    //{ add food from food list (pizza burger) submenu in there _menuItems.Add(new RemoveIngredientsItem(_menu));{ remove ingredient from list }
    //AddIngredientsItem { taken from list (in either food item or food manager unsure) then you can add extra ones to base }
    
   //something like this might need to have a child class? currently it is not working
  
   //  internal class AddNewOrderMenuItem 
   // {
     //   private FoodManager _Ingredients;

       // public AddNewOrderMenuItem(FoodManager Ingredients)
     //   {
     //       _Ingredients = Ingredients;
     //   }

     //   public override string MenuText()
     //   {
       //     return "Place new order";
// }

      //  public override void Select()
     //   {

       //     Console.WriteLine("Enter a customer name.");
       //     string name = Console.ReadLine();
       //     OrderMenu order = new OrderMenu(name);
       //     _Ingredients.AddOrder(order);
       // }

       //currently this is what i have added at the moment however im fairly certain it is not going to work
       //will have to look on how it is done
       internal class DisplayAllOrderMenu
       {
   private IEnumerable<OrderMenu> _order;
   public DisplayAllOrderMenu(IEnumerable<OrderMenu> orders)
   {
       _order = orders;
   }

   public override string MenuText()
   {
       return "display all orders";
   }

   public override void Select()
   {
       foreach (OrderMenu order in _order) { Console.WriteLine(order); }
   }
 }
   
   // DisplayAllFoodMenuItem {similar way in how displays all orders is done but replaced with fooditem
   
   //could use this way of writing since i will not need to do menus and then utilize methods instead unsure if it is better?
   // AddMenuItem(new AddCruiseMenuItem(Cruise2HolidayActions.AddCruise, this));
   
   
   
    //sample code but utilizes something from console helpers will most likely be put here along with other stuff
    //var cruisePrice = GetFloatFromInput("Enter the price of the cruise.");

    //var port = new PortData()
  //  {
   //     Activities = new List<ActivityData>(),
   // };
       

}