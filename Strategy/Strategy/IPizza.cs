using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IPizza
    {
        string Name { get; set; }
        IList<string> Ingredients { get; set; }
        void ListIngredients();
    }
}
