using Capstone_v2;
//this is code to select the main menus
//unsure if need to have restaurant name here or in MainMenu
Console.WriteLine("Hello, World!");

FoodManager foodManager = new FoodManager();

MainMenu MainMenu = new MainMenu(foodManager);
MainMenu.Select();