namespace Capstone_v2;
//this will hold the lists of orders /done this
//it will also be able to make new orders haven't done
//then have be outputted to the console /done this
//basically use ToString similar to code i have already have in other places

//Summary: this should have something that takes all the information for an order
//crates an order object then adds it to its own list
//and the actua creation of an order here
//doesn't matter where the user adds the data...

public class OrderHandler
{
    //method to make an order here and sorta be displayed correctly
    //This would be a list similar to how it is done in foodmanager
    
    //This should be kept in 
    public IEnumerable<Order.OrderMenu> OrderMenus {get { return _order; } }
    //should work
    internal List<Order.OrderMenu> _order;
    //new code
    
    //public List<Order> Orders { private set; get; } = new();
    
    //this is where orders will be added
    
   
   //this is for displaying the lists
   //it uses similar code from foodmanager for the lists
    public OrderHandler()
    {
        _order = new List<Order.OrderMenu>();
        _order.Add(new Order.OrderMenu("Simon"));
    }
      //then there should be the saving method here
      public void AddOrder(Order.OrderMenu order) { _order.Add(order); }

     
}
//this is going to be the main order stuff not changed from stable version
//rn it doesn't work due to certain items missing atm

//most of this stuff here hasn't been changed much
public class Order
{
    public class OrderMenu
    {
        //getter method and constructor
        public string Name { get; set; }

        public OrderMenu(string name)
        {
            Name = name;
        }
//shows what it is here
        public override string ToString()
        {
            return $"Order for: {Name}";
        }
    }
    
//keep the same stuff but the saving should be in orderhandler
    internal class AddNewOrderMenuItem : MenuItem
    {
        private FoodManager _Ingredients;

        public AddNewOrderMenuItem(FoodManager Ingredients)
        {
            _Ingredients = Ingredients;
        }

        public override string MenuText()
        {
            return "Place new order";
        }
//logic for adding an order non functional
        public override void Select()
        {

            Console.WriteLine("Enter a customer name.");
            string name = Console.ReadLine();
            OrderMenu order = new OrderMenu(name);
            _Ingredients.AddOrder(order);
        }

    }
  
    internal class DisplayAllOrderMenu : MenuItem
    {
        private IEnumerable<OrderMenu> _order;

        private FoodManager _manager;
//It wants me to have two seperate constructors for some reason ill will add that  
//need to have it be one constructor
        public DisplayAllOrderMenu(FoodManager managers,IEnumerable<OrderMenu> orders)
        {
            _order = orders;
            _manager = managers;
        }
        
        public override string MenuText()
        {
            return "display all orders";
        }
//should have it so it is selected
        public override void Select()
        {
            foreach (OrderMenu order in _order)
            {
                Console.WriteLine(order);
            }
        }
    }
}