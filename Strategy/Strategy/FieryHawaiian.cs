using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FieryHawaiian : IPizzaSrategy
    {
        public IPizza BuildPizza()
        {
            var pizza = new Pizza();
            pizza.Name = "FieryHawaiian";
            pizza.Ingredients.Add("Tomato sauce");
            pizza.Ingredients.Add("Cheese");
            pizza.Ingredients.Add("Canadian bacon");
            return pizza;
        }
    }
}
