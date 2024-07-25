using Capstone_v2;
//this is code to select the main menus

//Tried to have it so instead it takes it from orderHandler and that class instead of foodmanager 
//Then that didn't work and instead went with a mix of both ala what i did with my previous version
//that sorta works but idk if it saves correctly and again i haven't really written like brand new code stuff because idk what it should do 
//I would ideally have both values in menuItems and then have it so it saves in the OrderHandler and also displays it there
//then I can move on to something else like foods and then do finishing touches e.g., delivery, error checks, comments etc.

//this seems fine

FoodManager foodManager = new FoodManager();
MainMenu MainMenu = new MainMenu(foodManager);
MainMenu.Select();