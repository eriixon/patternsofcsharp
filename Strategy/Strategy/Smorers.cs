using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Smorers : IPizzaSrategy
    {
        public IPizza BuildPizza()
        {
            var pizza = new Pizza();
            pizza.Name = "Smorers";
            pizza.Ingredients.Add("Marshmallow sauce");
            pizza.Ingredients.Add("Chocolate");
            pizza.Ingredients.Add("Ashes");
            return pizza;
        }
    }
}
