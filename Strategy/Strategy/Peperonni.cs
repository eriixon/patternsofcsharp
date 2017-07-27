using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Peperonni : IPizzaSrategy
    {
        public IPizza BuildPizza()
        {
            var pizza = new Pizza();
            pizza.Name = "Pepperoni";
            pizza.Ingredients.Add("Tomato sauce");
            pizza.Ingredients.Add("Cheese");
            pizza.Ingredients.Add("Pepperoni");
            return pizza;
        }
    }
}
