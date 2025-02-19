namespace Capstone_v2;
//nothing here class useless... but will have stuff from other food classess like toppings etc.
//this would exist for encapsulation
public class Ingredients
{
    //something like this etc.
    public string Name { get; set; }
    public double Price { get; set; }
//constructor
    public Ingredients(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{{Name}},{Price}";
    }
}


//Here would be something similar to constructor chaining
//although done for both toppings and garnishes
//makes it look cleaner https://jonskeet.uk/csharp/constructors.html
//currently this is supposed to be a sort of nested constructor
public class Toppings(string name, int price) : Ingredients(name, price);
public class Garnishes(string name, int price) : Ingredients(name, price);
