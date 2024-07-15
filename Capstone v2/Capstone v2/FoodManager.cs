namespace Capstone_v2;
using System.Text;

//currently this does not work at the moment main idea is that this is similar to how it is done in summative 8
//currently holds the logic for shopManager and foodmanager


//here's some code from shopManager which i think is the main logic

internal class MainFoodManager  
{
    //get set methods
    public string Name { get; private set; }
    private List<FoodItem> _food { get; set; }
    //not working idk why
    internal List<OrderMenu> _order; 
    
    //Ienumerable means you can't really edit the list so it is good for making it more prodected which is used for these classes in question https://stackoverflow.com/questions/3628425/ienumerable-vs-list-what-to-use-how-do-they-work
    public IEnumerable<FoodItem> Foods { get { return _food; } }
    public IEnumerable<OrderMenu> OrderMenus { get { return _order; } }
    
   
    //price of the ingredients will be used here and the full price of the food
    //basic idea is to have a list of both pizza and burger and in it you get the recepie 
        
    public List<FoodManager> Pizza { get; private set; }
    public List<FoodManager> Burger { get; private set; }

    //pizza: Margharita| tomato sauce 050, cheese 040| 350
    //simple burger: beef 050, cheese 040 | 450
    
}

public class FoodManager 
{
        public List<FoodManager> Ingredients { get; private set; }
        
        //This seems useless? in the original code it seems to be here
        //in order for it to save different shapes unsure how to make it work 

        public FoodManager()
        {
            Ingredients = new List<FoodManager>();
        }

        public void AddShape(FoodManager pIngredients)
        {
            Ingredients.Add(pIngredients);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (FoodManager pIngredients in Ingredients)
            {
                sb.Append(pIngredients.ToString() + Environment.NewLine);
            }
            return sb.ToString();
        }
        
        //this is used to add a new food item although not working
        //possibly because i am not using any folders which makes it so namespace _food isn't there
        public void AddNewFoodItem(FoodItem food)
        {
            _food.Add(food);
        }
        
}