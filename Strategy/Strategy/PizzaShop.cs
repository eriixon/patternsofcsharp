using System.Collections.Generic;

namespace Strategy
{
    public class PizzaShop: IPizzaShop
    {
        private Dictionary<string, IPizzaSrategy> menu;
        public int MenuCount {
            get {
                return menu.Count;
            }
        }
        public PizzaShop()
        {
            menu = new Dictionary<string, IPizzaSrategy>();
        }

        public IPizza Build(IPizzaSrategy strategy)
        {
            return strategy.BuildPizza();
        }
        public IPizza OrderPizza(string name)
        {
            if (menu.ContainsKey(name)) return menu[name].BuildPizza();
            else return new Cheese().BuildPizza();
        }
        public void AddMenuItem(string name, IPizzaSrategy strategy)
        {
            menu.Add(name, strategy);
        }
    }
}
