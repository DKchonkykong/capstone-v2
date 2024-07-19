using System.Text;
namespace Capstone_v2

    //console helpers class, exit menu item , console and menu item  required for capstone
//Menus stuff is another part i think i might reuse stuff from before e.g.,
    //public override createMenu
//{_menuItems.clear()
//_menuItems.Add(DisplayAllFoods)
//_menuItems.Add(AddFoodItem)}  this is how it's supposed to look and how it will show up currently used in shopManager

{
    public static class ConsoleHelpers
    {
        public static bool GetChoice(string pMessage)
        {
            Console.WriteLine(pMessage);

            string? choice = GetNameFromInput("Enter Y to confirm, N to cancel");

            choice = choice.ToLower().Replace(" ", "");

            if(choice == "y" || choice == "yes")
            {
                return true;
            }
            else if(choice == "n" || choice == "no")
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public static string GetNameFromInput(string pMessage)
        {
            Console.WriteLine(pMessage);
            
            string? input = Console.ReadLine();

            return input == null ? "Untitled" : input;
        }
        
        public static int GetIntegerInRange(int pMin, int pMax, string pMessage)
        {
            if (pMin > pMax)
            {
                throw new Exception($"Minimum value {pMin} cannot be greater than maximum value {pMax}");
            }

            int result;

            do
            {
                Console.WriteLine(pMessage);
                Console.WriteLine($"Please enter a number between {pMin} and {pMax} inclusive.");

                string userInput = Console.ReadLine();

                try
                {
                    result = int.Parse(userInput);
                }
                catch
                {
                    Console.WriteLine($"{userInput} is not a number");
                    continue;
                }

                if (result >= pMin && result <= pMax)
                {
                    return result;
                }
                Console.WriteLine($"{result} is not between {pMin} and {pMax} inclusive.");
            } while (true);
        }

        public static float GetFloatFromInput(string pMessage)
        {
            float result;
            Console.WriteLine(pMessage);
            string userInput = Console.ReadLine();
            do
            {
                try
                {
                    result = float.Parse(userInput);
                    return result;
                }
                catch
                {
                    Console.WriteLine($"{userInput} is not a number");
                    continue;
                }
            } while (true);
        }
    }

    abstract class ConsoleMenu : MenuItem
    {
        protected List<MenuItem> _menuItems = new List<MenuItem>();
     
        public bool IsActive { get; set; }

        public abstract void CreateMenu();

        public override void Select()
        {
            IsActive = true;
            do
            {
                CreateMenu();
                string output = $"{MenuText()}{Environment.NewLine}";
                int selection = ConsoleHelpers.GetIntegerInRange(1, _menuItems.Count, this.ToString()) - 1;
                _menuItems[selection].Select();
            } while (IsActive);
        }
//idk if this section is needed it just seems to clear the menu 
        // public void ClearMenu()
        // {
        //     _menuItems.Clear();
        // }       

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(MenuText());
            for (int i = 0; i < _menuItems.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {_menuItems[i].MenuText()}");
            }
            return sb.ToString();
        }
    }
//this is where every MenuItem goes to for selecting and text
  internal abstract class MenuItem
  {
      public abstract void Select();
      public abstract string MenuText();
    }
//there already is this
    class ExitMenuItem : MenuItem
    {
        private ConsoleMenu _menu;
        private string _menuText;

        public ExitMenuItem(ConsoleMenu parentItem, string menuText = "Exit")
        {
            _menu = parentItem;
            _menuText = menuText;
        }

        public override string MenuText()
        {
            return _menuText;
        }

        public override void Select()
        {
            _menu.IsActive = false;
        }
    }
}