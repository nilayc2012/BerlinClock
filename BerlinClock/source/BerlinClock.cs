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
            //Test case 1: Default format hh:mm:ss
            Console.WriteLine(" **** Testcase 1 **** \n");
            Console.WriteLine("Please enter the time in this format hh:mm:ss \n");
            string time = Console.ReadLine();
            Console.WriteLine(time);

            //Test case 2: Red light as R, yellow as Y and off as O
            Console.WriteLine("\n\n **** Testcase 2 **** \n");
            BerlinClockFinder bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine(bcf.formatToBerlinClock(time)+"\n");

            //Test case 3: Red light as R, yellow as G for green and off as B for black
            Console.WriteLine("\n\n **** Testcase 3 **** \n");
            bcf = new BerlinClockFinder("R","G","B");
            Console.WriteLine(bcf.formatToBerlinClock(time)+"\n");

            //Test case 4: Input as datetime object with current time
            Console.WriteLine("\n\n **** Testcase 4 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("Current Time is "+DateTime.Now.ToString("HH:mm:ss") + "\n");
            Console.WriteLine("In Berlin clock format "+bcf.formatToBerlinClock(DateTime.Now)+"\n");

            //Test case 5: Input of hour, minute, second separately as strings
            Console.WriteLine("\n\n **** Testcase 5 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("Enter the hour");
            string hour = Console.ReadLine();
            Console.WriteLine("Enter the minute");
            string minute = Console.ReadLine();
            Console.WriteLine("Enter the second");
            string second = Console.ReadLine();
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(hour,minute,second) + "\n");

            //Test case 6: Input of hour, minute, second separately as integers
            Console.WriteLine("\n\n **** Testcase 6 **** \n");
            int n;
            if (!int.TryParse(hour, out n) || !int.TryParse(minute, out n) || !int.TryParse(second, out n))
            {
                Console.WriteLine("wrong input format");
            }
            else
            {
                bcf = new BerlinClockFinder("R", "Y", "O");
                Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(Int32.Parse(hour), Int32.Parse(minute), Int32.Parse(second)) + "\n");
            }

            //Test case 7: 12 hour time format input as string
            Console.WriteLine("\n\n **** Testcase 7 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("Current Time is " + DateTime.Now.ToString("hh:mm:ss tt") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.ToString("hh:mm:ss tt")) + "\n");

            //Test case 8: 12 hour different input format as a string
            Console.WriteLine("\n\n **** Testcase 8 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("Current Time is " + DateTime.Now.ToString("tt hh:mm:ss") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.ToString("tt hh:mm:ss")) + "\n");


            //Test case 9: 12 hour different input format as a string (Time in am. Added 3 hour to current time to make it an AM time)
            Console.WriteLine("\n\n **** Testcase 9 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.AddHours(3).ToString("tt hh:mm:ss") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.AddHours(3).ToString("tt hh:mm:ss")) + "\n");

            //Test case 10: 12 hour different input format as a string (Time in am. Added 3 hour to current time to make it an AM time)
            Console.WriteLine("\n\n **** Testcase 10 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.AddHours(3).ToString("hh:mm:ss tt ") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.AddHours(3).ToString("tt hh:mm:ss")) + "\n");

            //Test case 11: Date and time input format for PM
            Console.WriteLine("\n\n **** Testcase 11 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.ToString("MM/dd/yy hh:mm:ss tt ") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.ToString("MM/dd/yy hh:mm:ss tt ")) + "\n");

            //Test case 12: Date and time input format for AM
            Console.WriteLine("\n\n **** Testcase 12 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.AddHours(3).ToString("MM/dd/yy hh:mm:ss tt ") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.AddHours(3).ToString("MM/dd/yy hh:mm:ss tt ")) + "\n");

            //Test case 13: Date and time input format for 24 Hours format
            Console.WriteLine("\n\n **** Testcase 13 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.ToString("MM/dd/yy HH:mm:ss ") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.ToString("MM/dd/yy HH:mm:ss ")) + "\n");

            //Test case 14: Date and time format with date coming later
            Console.WriteLine("\n\n **** Testcase 14 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.ToString(" HH:mm:ss MM/dd/yy") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.ToString("HH:mm:ss MM/dd/yy")) + "\n");

            //Test case 15: Date and time format with date coming later
            Console.WriteLine("\n\n **** Testcase 15 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine(bcf.formatToBerlinClock("MM/dd/yy") + "\n");

            //Test case 16: different time format
            Console.WriteLine("\n\n **** Testcase 16 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.AddHours(12).ToString("h:mm:ss.ff t") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.AddHours(12).ToString("h:mm:ss.ff t")) + "\n");

            //Test case 17: different time format
            Console.WriteLine("\n\n **** Testcase 17 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.ToString("h:mm:ss.ff t") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.ToString("h:mm:ss.ff t")) + "\n");

            //Test case 18: Without time
            Console.WriteLine("\n\n **** Testcase 18 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.ToString("d MMM yyyy") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.ToString("d MMM yyyy")) + "\n");

            //Test case 19: different time format
            Console.WriteLine("\n\n **** Testcase 19 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.ToString("HH:mm:ss.f") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.ToString("HH:mm:ss.f")) + "\n");

            //Test case 20: 
            Console.WriteLine("\n\n **** Testcase 20 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.ToString("dd MMM HH:mm:ss") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.ToString("dd MMM HH:mm:ss")) + "\n");

            //Test case 21: 
            Console.WriteLine("\n\n **** Testcase 21 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.ToString("HH:mm:ss.ffffzzz") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.ToString("HH:mm:ss.ffffzzz")) + "\n");

            //Test case 22: 
            Console.WriteLine("\n\n **** Testcase 22 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.ToString("zzzHH:mm:ss.ffff") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.ToString("zzzHH:mm:ss.ffff")) + "\n");

            //Test case 23: 
            Console.WriteLine("\n\n **** Testcase 23 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.AddHours(12).ToString("zzzHH:mm:ss.ffff") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.AddHours(12).ToString("zzzHH:mm:ss.ffff")) + "\n");

            //Test case 24: 
            Console.WriteLine("\n\n **** Testcase 24 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.AddHours(12).ToString("ffffzzzHH:mm:ss") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.AddHours(12).ToString("ffffzzzHH:mm:ss")) + "\n");

            //Test case 25: 
            Console.WriteLine("\n\n **** Testcase 25 **** \n");
            bcf = new BerlinClockFinder("R", "Y", "O");
            Console.WriteLine("The Time is " + DateTime.Now.ToString("ffffzzzHH:mm:ss") + "\n");
            Console.WriteLine("In Berlin clock format " + bcf.formatToBerlinClock(DateTime.Now.ToString("ffffzzzHH:mm:ss")) + "\n");


        }
    }
}
