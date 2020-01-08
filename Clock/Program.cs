using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Clock
{
    class Program
    {
        static void Main()
        {
            MilitaryTimeToRegularTime militaryTimeToRegularTime = new MilitaryTimeToRegularTime();
            militaryTimeToRegularTime.Clock();
            


            Console.ReadKey();
        }
        
    
    }
}
