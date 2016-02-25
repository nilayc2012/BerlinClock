using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.source
{
    
    class BerlinClock
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the time in this format hh:mm:ss");
            string time = Console.ReadLine();
            Console.WriteLine(time);

            BerlinClockFinder bcf = new BerlinClockFinder('R','G','B');
            Console.WriteLine(bcf.formatToBerlinClock(time));
            
        }
    }
}
