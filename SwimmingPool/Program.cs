using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPool
{
    //definition of delegate
    public delegate T CleanPool<T>(decimal pHLevel) where T : ICleanSwimmingPool;

    class Program
    {


        static void Main(string[] args)
        {
            SwimmingPool pool = new SwimmingPool();

            pool.SetCleaner(AllCleaners<PoolBoy>);

            if (pool.Clean(100))
            {
                System.Console.WriteLine("Pool boy cleaned the pool.");
            }
            else
            {
                pool.SetCleaner(AllCleaners<PumpCleaner>);
                if(pool.Clean(100))
                { 
                    Console.WriteLine("The pump cleaned the pool.");
                }
            }
        }

        private static T AllCleaners<T>(decimal phLevel) where T : ICleanSwimmingPool, new ()
        {
            var localInstance = new T
            {
               OldPhLevel = (int)phLevel
            };
            return localInstance;
        }
    }
  
    
}

