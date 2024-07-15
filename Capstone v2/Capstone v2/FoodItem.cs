namespace Capstone_v2;
/// <This is FoodItem it is supposed to be the class that has all of the values.>
/// currently this code does not do anything since it's supposed to link to the bit where you have to show all food items
/// <(this is good for showing all of the foods in a list e.g., inside of shop manager although unsure if needed)>
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
//what this will do is to be the main class i.e., will include a list of the main food classes
//then it will have a class with base lists that then you can edit over stuff 
//e.g., Pizza with peperonni then there's another list with extra toppings 

//sample code atm not working but basic idea was to have it so it shows up when picking "select all food items"
//it displays it there

// internal class FoodManager
// {
//     list<FoodItemObject> FoodList = new List<FoodItemObject>();
//    This will make two food item objects
//     FoodItem fooditem1 = new FoodItem("Pizza", "Margharitta", 500);
//
// I add those fooditem object to the list
//     FoodItem fooditem2 = new FoodItem("Hamburger", "Cheesebuger", 350);
//     _food.Add(fooditem1);
//     _food.Add(fooditem2);
// }
//
// This would make it so it is diplayed in the console
// However i am sure it will not display it correctly due to
// how the menus work (currently have no solution for it)
// foreach (var fooditem in foodList)
//{
// console.writeLine(fooditem);
//}
//maybe utilizing Tostring but i only want to show all lines from both pizza and burger
//
// public override string ToString()