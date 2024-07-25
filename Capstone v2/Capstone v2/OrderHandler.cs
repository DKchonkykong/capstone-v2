namespace Capstone_v2; 

//Summary: this should have something that takes all the information for an order
//crates an order object then adds it to its own list
//and the actual creation of an order here
//doesn't matter where the user adds the data...

//Currently you need to have some pieces of the code go to FoodMangaer
//Unsure if the local variable _ingredients matter

public class OrderHandler
{
    //method to make an order here and sorta be displayed correctly
    //This would be a list similar to how it is done in foodmanager
    
    //This should be kept in although took it from foodmanager
    //think it should be back into foodmanager?
    public IEnumerable<Order.OrderMenu> OrderMenus {get { return _order; } }
    //should work
    internal List<Order.OrderMenu> _order;
    
    //this is where orders will be added
    //I don't know if i am going to add it here
   
    //this is for displaying the lists
   //it uses similar code from foodmanager for the lists
    public OrderHandler()
    {
        _order = new List<Order.OrderMenu>();
        _order.Add(new Order.OrderMenu("Simon"));
    }
      //This would save stuff here currently is trying to do it from orderhandler
      //might be better to have it in food manager idk. or other possible ways...
      //other possible solutions?
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
//Displays whos order it is
//think i can do the same to show them if it is a delivery
//Would do this later - since it's going to be quite similar would need to have an if statement for delivery and calculations made in there.
        public override string ToString()
        {
            return $"Order for: {Name}";
        }
    }
    
//keep the same stuff but the saving should be in orderhandler
//going to change from referencing foodmanager to orderHandler
//should not break anything since it a local value and not using food manager for anything else

//decided instead of having both order handler and foodmanager in there since it works better
    internal class AddNewOrderMenuItem : MenuItem
    {
        private OrderHandler _orderItem;
        private FoodManager _manager;

        public AddNewOrderMenuItem(FoodManager manager, OrderHandler orderItem)
        {
            _orderItem = orderItem;
            _manager = manager;
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
            _orderItem.AddOrder(order);
        }

    }
  //might have to change it here as well to reference orderhandler
  //unsure if it is going to be better or just going to be a foodmanager 2.0 moment
//originally did not have foodmanager and needed to have it for a bug
  //doesn't work with this method...
    internal class DisplayAllOrderMenu : MenuItem
    {
        private IEnumerable<OrderMenu> _order;
        private FoodManager _manager;

//It wants me to have two seperate constructors for some reason ill will add that  
//need to have it be one constructor
//changed it so both foodmanager and ordermenu are in there
        public DisplayAllOrderMenu(FoodManager manager, IEnumerable<OrderMenu> orders)
        {
            _order = orders;
            _manager = manager;
        }
        //displays text
        public override string MenuText()
        {
            return "display all orders";
        }
//This checks how many lists are there for the customer and displays them approprietly
//similar code could be used for checking how many customer was a delivery
        public override void Select()
        {
            foreach (OrderMenu order in _order)
            {
                Console.WriteLine(order);
            }
        }
    }
}