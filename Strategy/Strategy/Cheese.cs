using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Cheese : IPizzaSrategy
    {
        public IPizza BuildPizza()
        {
            var pizza = new Pizza();
            pizza.Name = "Cheese";
            pizza.Ingredients.Add("Tomato sauce");
            pizza.Ingredients.Add("Cheese");
            return pizza;
        }
    }
}
