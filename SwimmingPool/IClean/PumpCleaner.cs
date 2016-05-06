using System;

namespace SPool
{
    class PumpCleaner : ICleanSwimmingPool
    {
        public int NewPhLevel { get; private set; }
        public int OldPhLevel { get; set; }

        public PumpCleaner()
        {
        }

        public bool PoolWasClean()
        {
            NewPhLevel = OldPhLevel / 2;
            Console.WriteLine("The pump can clean the pool.");
            return true;
        }
    }
}
