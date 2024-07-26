namespace Capstone_v2;
using System.Text;

//currently this does not work at the moment main idea is that this is similar to how it is done in summative 8
//currently holds the logic for shopManager and foodmanager


//here's some code from shopManager which I think is the main logic

internal class FoodManager
{
    //get set methods
    public string Name { get; private set; }

    private List<FoodItem> _food { get; set; }
    

    //Ienumerable means you can't really edit the list so it is good for making it more prodected which is used for these classes in question
    //https://stackoverflow.com/questions/3628425/ienumerable-vs-list-what-to-use-how-do-they-work
    public IEnumerable<FoodItem> Foods
    {
        get { return _food; }
    }
    
//this is a list of foodItems currently there's two for testing purposes but will have more than 2 supposed to show up when you are picking a foodItem

      public FoodManager()
    {
        
        _food = new List<FoodItem>();

        FoodItem fooditem1 = new FoodItem("Pizza", "Margharitta", 500);

        _food.Add(fooditem1);

        FoodItem fooditem2 = new FoodItem("Hamburger", "Cheesebuger", 350);
        
        _food.Add(fooditem2);
        
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
//it wants to have this here
    public void AddOrder(Order.OrderMenu order)
    {
        Console.WriteLine("Something Witty");
    }
}


