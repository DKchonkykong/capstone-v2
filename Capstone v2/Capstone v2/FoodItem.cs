namespace Capstone_v2;



/// <This is FoodItem it is supposed to be the class that has all of the values.>
/// currently this code does not do anything since it's supposed to link to the bit where you have to show all food items
/// <(this is good for showing all of the foods in a list e.g., inside of shop manager although unsure if needed also make sure to have i)>
public class FoodItem
{
    //variables that are stored here
    public string FoodName { get; set; }
    public double Price { get; set; }
    public string Ingredients { get; set; }
//constructor
    public FoodItem(string foodName, string ingredients, double price)
    {
        FoodName = foodName;
        Price = price;
        Ingredients = ingredients;
    }



    public override string ToString()
    {
        return $"{FoodName} with {Ingredients} , {Price}";
    }
}
