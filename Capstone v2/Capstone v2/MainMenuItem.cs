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


    internal class OrderMenu
    {
        //getter method and constructor
        public string Name { get; set; }

        public OrderMenu(string name)
        {
            Name = name;
        }

//would ideally have something be used by this (showing name for order) but i don't think it works might be due ToString method
        public override string ToString()
        {
            return $"Order for: {Name}";
        }
    }


    internal class AddNewOrderMenuItem : MenuItem
    {
        private FoodManager _Ingredients;

        public AddNewOrderMenuItem(FoodManager ingredients)
        {
            _Ingredients = ingredients;
        }

        public override string MenuText()
        {
            return "Place new order";
        }

        //ingredients.addOrder needs to have line in foodManager although it doesn't seem to be fully working
        //something about param type order menu 
        public override void Select()
        {

            Console.WriteLine("Enter a customer name.");
            string name = Console.ReadLine();
            OrderMenu order = new OrderMenu(name);
            //Got this issue and unsure why it doesn't work 
            _Ingredients.AddOrder(order);
        }
    }

    internal class DisplayAllOrderMenu : MenuItem
    {
        private IEnumerable<OrderMenu> _order;

        public DisplayAllOrderMenu(IEnumerable<OrderMenu> orders)
        {
            _order = orders;
        }
// another constructor here needed for it to run
        public DisplayAllOrderMenu(FoodManager manager)
        {
            
        }

        public override string MenuText()
        {
            return "display all orders";
        }

        public override void Select()
        {
            foreach (OrderMenu order in _order)
            {
                Console.WriteLine(order);
            }
        }
    }



// </Old code for adding foods no support for lists>


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

            //supposed to be something here, but it doesn't seem to be working? idk why
            //  _ingredients.AddNewFoodMenuItem(food);
        }
    }

// this is for displaying all food items but fairly sure i need to have an actual list in food items for it to be working
    internal class DisplayAllFoodMenuItem : MenuItem
    {
        private IEnumerable<FoodItem> _foods;

        public DisplayAllFoodMenuItem(IEnumerable<FoodItem> foods)
        {
            _foods = foods;
        }

        //method here for the FoodManager in order for it to work and displays all of the foods that have been updated
        public DisplayAllFoodMenuItem(FoodManager ingredients)
        {
        }

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





// DisplayAllFoodMenuItem {similar way in how displays all orders is done but replaced with fooditem
   
   //could use this way of writing since i will not need to do menus and then utilize methods instead unsure if it is better?
   // AddMenuItem(new AddCruiseMenuItem(Cruise2HolidayActions.AddCruise, this));
   
   
   
    //sample code but utilizes something from console helpers will most likely be put here along with other stuff
    //var cruisePrice = GetFloatFromInput("Enter the price of the cruise.");

    //var port = new PortData()
  //  {
   //     Activities = new List<ActivityData>(),
   // };
       

