namespace Capstone_v2; 

//Summary: this should have something that takes all the information for an order
//crates an order object then adds it to its own list
//and the actual creation of an order here
//doesn't matter where the user adds the data...

//Currently you need to have some pieces of the code go to FoodMangaer to store foods

public class OrderHandler
{
    //method to make an order here and sorta be displayed correctly
    //This would be a list similar to how it is done in foodmanager
    
    //This should be kept in although took it from foodmanager
    //think it should be back into foodmanager?
    
    //not necesarry
    // public IEnumerable<Order.OrderMenu> OrderMenus {get { return _order; } }
    // //should work
    // internal List<Order.OrderMenu> _order;
    
    //this is where orders will be added
    //I don't know if i am going to add it here
   
    //this is for displaying the lists
   //it uses similar code from foodmanager for the lists 
   //basically removing the premade order text
   
   //this is a list of order now think it should work
   //will also need to add a way for it to interact with fooditem
   
   public List<Order> _order { get; set; } = new List<Order>();
     
   /* This is now old code 
     public OrderHandler()
     {
         _order = new List<Order.OrderMenu>();
         //_order.Add(new Order.OrderMenu("Simon"));
     }
     */
    
    //new code test basic structure have a loop?
    // public void ToString()
    // {
    //     foreach (var VARIABLE in Console)
    //     {
    //         Console.WriteLine("test");
    //         foreach (var VARIABLE in Console)
    //         {
    //             Console.WriteLine(FoodItem.Tostring());
    //         }
    //     }
    // }
    
    
      //This would save stuff here currently is trying to do it from orderhandler
      //might be better to have it in food manager idk. or other possible ways...
      //other possible solutions?
      
//I know I got this which is similar to what place order is doing
//it's supposed to be updating it each time but with _order

    public void AddOrder(Order order)
      {
          _order.Add(order);
      }
//this to string pretty sure is supposed to be my own version of addNewOrderItem

    public void ToString()
    {
        //some text here
    }
//then here should be like a place order, currently there's addneworder
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
            Order.OrderMenu order = new Order.OrderMenu(name);
            //This also seems problamatic since it wants it to be saved inside foodmanager
            _Ingredients.AddOrder(order);
        }
    }

}
//this is going to be the main order stuff not changed from stable version
//rn it doesn't work due to certain items missing atm

//most of this stuff here hasn't been changed much
public class Order
{
    //Displays whos order it is and any extra information e.g., delivery and the food items
    public class OrderMenu
    {
        //getter method and constructor
        public string Name { get; set; }

        public OrderMenu(string name)
        {
            Name = name;
        }

//think i can do the same to show them if it is a delivery
//Would do this later - since it's going to be quite similar would need to have an if statement for delivery and calculations made in there.
        public override string ToString()
        {
            return $"Order for: {Name}, Total:";
        }
    }
    
//this is commented code from where the original location was for addOrder
    /*internal class AddNewOrderMenuItem : MenuItem
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

    }*/
  //might have to change it here as well to reference orderhandler
  //unsure if it is going to be better or just going to be a foodmanager 2.0 moment
//originally did not have foodmanager and needed to have it for a bug
  
    //This is supposed to display orders stuff although unsure if i should have some code here be used somewhere else
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
//It wants me to do this which idk why because i already have another class that has the same stuff 
//think ill work on fooditems and then other stuff
        public DisplayAllOrderMenu(FoodManager manager)
        {
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