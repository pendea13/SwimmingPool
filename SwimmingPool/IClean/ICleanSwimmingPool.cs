using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPool
{
     public interface ICleanSwimmingPool
    {
        int OldPhLevel { get; set; }
        int NewPhLevel { get; }
        bool PoolWasClean();
    }
}
