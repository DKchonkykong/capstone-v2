namespace Capstone_v2;

//this is going to be where the objects will be loaded in 
public class OrderHandler
{
    //method to make an order here and sorta be displayed correctly
    //This would be a list similar to how it is done in foodmanager
    public List<Order> Orders { private set; get; }

    
    //code here atm but idk if it is needed 
    // _order = new List<Order.OrderMenu>();
    // _order.Add(new Order.OrderMenu("Simon"));
}
//this is going to be the main order stuff not changed from stable version
//rn it doesn't work due to certain items missing atm
//will have to implement them soon since were from mainmenuitem
//could ask for a reminder
public class Order
{
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
    
    
  
    internal class DisplayAllOrderMenu : MenuItem
    {
        private IEnumerable<OrderMenu> _order;

        private FoodManager _manager;
        //constructor changed it so it has both constructors
        //It wants me to have two seperate constructors for some reason ill will add that  
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