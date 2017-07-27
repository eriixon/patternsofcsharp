using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Pizza: IPizza
    {
        public IList<string> Ingredients { get; set; }
        public string Name { get; set; }
        public Pizza()
        {
            Ingredients = new List<string>();
        }

        public void ListIngredients()
        {
            Console.WriteLine($"{Name} pizza has ingredients:");
            foreach (var item in Ingredients)
            {
                Console.WriteLine(item);
            }
        }
    }
}
