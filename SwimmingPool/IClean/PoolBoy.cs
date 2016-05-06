using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPool
{
    public class PoolBoy : ICleanSwimmingPool
    {
        public int NewPhLevel { get; private set; }
        public int OldPhLevel { get; set; }

        public PoolBoy()
        {
        }

        public bool PoolWasClean()
        {
            NewPhLevel = OldPhLevel - 1;
            Console.WriteLine("The pool boy is too cute to clean the pool.");
            return false;
        }
    }
}
