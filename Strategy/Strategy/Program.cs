using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzashop = new PizzaShop();
            pizzashop.AddMenuItem("Pepperoni", new Peperonni());
            pizzashop.AddMenuItem("MeatLovers", new MeatLovers());
            pizzashop.AddMenuItem("Smorers", new Smorers());
            pizzashop.AddMenuItem("FieryHawaiian", new FieryHawaiian());
            pizzashop.AddMenuItem("CorDog", new CornDog());
            pizzashop.AddMenuItem("Cheese", new Cheese());

            var pizza = pizzashop.OrderPizza("Pepperoni");
            pizza.ListIngredients();
        }
    }
}
