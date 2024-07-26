namespace Capstone_v2;
//this is a class that is supposed to be a sub menu think of how there was 
internal class MainMenuItem
{
    //What most likely I will need here as individual classes: 
    //AddNewFoodMenuItem
    //{ add food from food list (pizza burger) submenu in there _menuItems.Add(new RemoveIngredientsItem(_menu));{ remove ingredient from list }
    //AddIngredientsItem { taken from list (in either food item or food manager unsure) then you can add extra ones to base }

    //something like this might need to have a child class?
    //curently there's code from stable ver of capstone then might change if stuff doesn't work
    

// </Old code for adding foods will be changed to support for lists>

// I think this structure works so maybe have similar one in order handler?
    internal class AddNewFoodMenuItem : MenuItem
    {
        private FoodManager _ingredients;
//constructor

        public AddNewFoodMenuItem(FoodManager ingredients)
        {
            _ingredients = ingredients;
        }

        public override string MenuText()
        {
            return "Add new food item";
        }

        public override void Select()
        {
            Console.WriteLine("Enter the name of the food you want to pick");
            string foodName = Console.ReadLine();

            Console.WriteLine("Enter the garnishes and or toppings you want to pick");
            string ingredients = Console.ReadLine();
            //need to parse this
            Console.WriteLine("Enter Price");
            int price = int.Parse(Console.ReadLine());
            FoodItem food = new FoodItem(foodName, ingredients, price);
        }
    }

// this is for displaying all food items but fairly sure I need to have an actual list in food items for it to be working
    internal class DisplayAllFoodMenuItem : MenuItem
    {
        private IEnumerable<FoodItem> _foods;
//maybe it doesn't work because of this issue that says it cannot be converted...
        public DisplayAllFoodMenuItem(IEnumerable<FoodItem> foods)
        {
            _foods = foods;
        }
        //is necessary and for some reason wants ingredients
         public DisplayAllFoodMenuItem(FoodManager ingredients)
         {}
        
        public override string MenuText()
        {
            return "View All Food Items";
        }

        public override void Select()
        {
            foreach (FoodItem food in _foods)
            {
                Console.WriteLine(food);
            }
        }
    }
}






   
    //sample code but utilizes something from console helpers will most likely be put here along with other stuff
    //var cruisePrice = GetFloatFromInput("Enter the price of the cruise.");

    //var port = new PortData()
  //  {
   //     Activities = new List<ActivityData>(),
   // };
       

