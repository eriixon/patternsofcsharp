using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new MonsterFactory();

            for (int i = 0; i < 100; i++)
            {
                var monster = factory.CreateMonster();
                Console.WriteLine($"{monster.Name} - {monster.Health}");
            }


        }
    }
}
