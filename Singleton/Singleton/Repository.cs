using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Repository
    {
        private static Repository instance;
        private Repository()
        {
        }
        public static Repository Instance()
        {
            if (instance == null) instance = new Repository();
            return instance;
        }
        public void DoSomeThing()
        {
            Console.WriteLine("Hello Pepole!");
        }
    }
}
