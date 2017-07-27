using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class RandomGenerator: IRandom
    {
        public int GetNext(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}
