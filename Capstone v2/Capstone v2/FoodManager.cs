namespace Capstone_v2;
using System.Text;

//currently this does not work at the moment main idea is that this is similar to how it is done in summative 8
//currently holds the logic for shopManager and foodmanager


//here's some code from shopManager which i think is the main logic

internal class FoodManager
{
    //get set methods
    public string Name { get; private set; }

    private List<FoodItem> _food { get; set; }

    //should work
    internal List<MainMenuItem.OrderMenu> _order;

    //Ienumerable means you can't really edit the list so it is good for making it more prodected which is used for these classes in question https://stackoverflow.com/questions/3628425/ienumerable-vs-list-what-to-use-how-do-they-work
    public IEnumerable<FoodItem> Foods
    {
        get { return _food; }
    }
//this is supposed to work
    public IEnumerable<MainMenuItem.OrderMenu> OrderMenus {get { return _order; } }

//got this fixed sorta
// only works adding customer name not displaying it?
      public FoodManager()
    {
        
        _food = new List<FoodItem>();

        FoodItem fooditem1 = new FoodItem("Pizza", "Margharitta", 500);

        _food.Add(fooditem1);

        FoodItem fooditem2 = new FoodItem("Hamburger", "Cheesebuger", 350);
        
        _food.Add(fooditem2);
        
        _order = new List<MainMenuItem.OrderMenu>();
        _order.Add(new MainMenuItem.OrderMenu("Simon"));
    }

    public List<FoodManager> Pizza { get; private set; }
    public List<FoodManager> Burger { get; private set; }

    //pizza: Margharita| tomato sauce 050, cheese 040| 350
    //simple burger: beef 050, cheese 040 | 450
    
    //Should be adding a food item
    public void AddNewFoodItem(FoodItem food)
    {
        _food.Add(food);
    }
    
    //this line seems to work now
    public void AddOrder(MainMenuItem.OrderMenu order) { _order.Add(order); }

}












//this is a useless class since it doesn't do anything
public class UselessClass
{
public List<UselessClass> Ingredients { get; private set; }
        
        //This seems useless? in the original code it seems to be here
        //in order for it to save different shapes unsure how to make it work 

        public UselessClass()
        {
            Ingredients = new List<UselessClass>();
        }

        public void AddShape(UselessClass pIngredients)
        {
            Ingredients.Add(pIngredients);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (UselessClass pIngredients in Ingredients)
            {
                sb.Append(pIngredients.ToString() + Environment.NewLine);
            }
            return sb.ToString();
        }
        
        //this is used to add a new food item although not working
        //possibly because i am not using any folders which makes it so namespace _food isn't there
       
        // public void AddNewFoodItem(FoodItem food)
        // {
        //     _food.Add(food);
        // }
        
}