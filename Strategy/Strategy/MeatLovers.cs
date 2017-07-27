using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MeatLovers : IPizzaSrategy
    {
        public IPizza BuildPizza()
        {
            var pizza = new Pizza();
            pizza.Name = "MeatLovers";
            pizza.Ingredients.Add("Tomato sauce");
            pizza.Ingredients.Add("Cheese");
            pizza.Ingredients.Add("Canadian bacon");
            pizza.Ingredients.Add("Beef");
            return pizza;
        }
    }
}
