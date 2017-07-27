using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CornDog: IPizzaSrategy
    {
        public IPizza BuildPizza()
        {
            var pizza = new Pizza();
            pizza.Name = "CornDog";
            pizza.Ingredients.Add("BBQ sauce");
            pizza.Ingredients.Add("Cheese");
            pizza.Ingredients.Add("Corn Dogs");
            return pizza;
        }
    }
}
