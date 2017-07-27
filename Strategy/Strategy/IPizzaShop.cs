using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IPizzaShop
    {
        IPizza Build(IPizzaSrategy strategy);
        IPizza OrderPizza(string name);
        int MenuCount { get; }
        void AddMenuItem(string name, IPizzaSrategy strategy);
    }
}
