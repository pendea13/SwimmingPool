using System;

namespace SPool
{
    public class SwimmingPool
    {
        CleanPool<ICleanSwimmingPool> something;

        public void SetCleaner(CleanPool<ICleanSwimmingPool> newDelegate)
        {
            something = newDelegate;
        }

        public bool Clean(decimal ph)
        {
            if (something == null)
            {
                Console.WriteLine("No cleaner defined.");
                return false;
            }
            else
            {
                var cleaner = something.Invoke(ph);
                return cleaner.PoolWasClean();
            }
        }
    }
}
