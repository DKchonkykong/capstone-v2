namespace Capstone_v2;
//would have stuff like a shopmanager but unsure if it's needed and might make it too complicated to implement it here
//currently there's nothing here, would have simple values like price and name and then be linked to a list of some kind
public class Burger
{
    //struct then {
    //private unique ID
    //public food name, price, recepie.} 
    
    //basic outline of how it's going to be
    public double Price { get; set; }
    public string Name { get; set; }

    public Burger(string name, double price)
    {
        Name = name;
        Price = price;
    }  
    public override string ToString()
    {
        return $"{Name} , {Price}";
    }
}
//this will probably be similar to what i have before
public class Garnishes
{
    //struct then {
    //private unique ID
    //public food name, price, recepie.}  
    //how it's gonna be with tags similar to what i've done before
    public double Price { get; set; }
    public string Name { get; set; }

    public Garnishes(string name, double price)
    {
        Name = name;
        Price = price;
    }  
    public override string ToString()
    {
        return $"{Name} , {Price}";
    }
    
}

