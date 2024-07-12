namespace Capstone_v2;
//will most likely have code here similar to what I had before
//this is more so basic stuff and pizza and toppings in the same class
//will most likely be used in a list


public class Pizza
{
    //struct then {
    //private unique ID
    //public food name, price, recepie.} 
    //basic outline of how it will look
    public double Price { get; set; }
    public string Name { get; set; }

    public Pizza(string name, double price)
    {
        Name = name;
        Price = price;
    }  
    public override string ToString()
    {
        return $"{Name} , {Price}";
    }
}
//when selecting no chicken it's supposed to be a pizza without that ingredient? so maybe i need to make multiple lists
//that then you can pick?
public class Toppings
{
    //struct then {
    //private unique ID 
    //public food name, price, recepie.} 
    //this is supposed to be sorta like tags that will be used in other areas e.g., food manager
    public double Price { get; set; }
    public string Name { get; set; }

    public Toppings(string name, double price)
    {
        Name = name;
        Price = price;
    }  
    public override string ToString()
    {
        return $"{Name} , {Price}";
    }
    
}