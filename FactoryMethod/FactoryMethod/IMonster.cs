using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IMonster
    {
        string Name { get; set; }
        int Health { get; set; }
    }
}
