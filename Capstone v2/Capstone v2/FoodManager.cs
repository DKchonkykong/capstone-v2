namespace Capstone_v2;
using System.Text;

//currently this does not work at the moment main idea is that this is similar to how it is done in summative 8
//currently holds the logic for shopManager
public class FoodManager
{
        public List<ShopManager> Ingredients { get; private set; }

        public FoodManager()
        {
            Ingredients = new List<ShopManager>();
        }

        public void AddShape(ShopManager pIngredients)
        {
            Ingredients.Add(pIngredients);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (ShopManager pIngredients in Ingredients)
            {
                sb.Append(pIngredients.ToString() + Environment.NewLine);
            }
            return sb.ToString();
        }
    }