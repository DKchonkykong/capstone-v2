using Capstone_v2;
//this is code to select the main menus
//Line 9 also isn't working. I think would be good to use breakpoints in the og version and see where it goes.
Console.WriteLine("Hello, World!");

FoodManager foodManager = new FoodManager();

MainMenu MainMenu = new MainMenu(foodManager);
MainMenu.Select();