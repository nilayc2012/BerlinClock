using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.source
{
    class BerlinClockFinder : BerlinClockFinderParent<string>
    {

        public BerlinClockFinder()
        {
        }

        public BerlinClockFinder(char red,char yellow,char off)
        {
            this.red = red;
            this.yellow = yellow;
            this.off = off;
        }


        override public string formatToBerlinClock(string time)
        {
            string[] times = time.Split(':');
            String output = null;

            if (Int32.Parse(times[2]) % 2 == 0)
            {
                output = this.yellow+" ";
            }
            else
            {
                output = this.off+" ";
            }

            int noOfRedFR = Int32.Parse(times[0]) / 5;
            int noOfRedSR = Int32.Parse(times[0]) % 5;

            for (int i = 0; i < 4; i++)
            {
                if (i < noOfRedFR)
                {
                    output = output + this.red;
                }
                else
                {
                    output = output + this.off;
                }
            }

            output = output + " ";

            for (int i = 0; i < 4; i++)
            {
                if (i < noOfRedSR)
                {
                    output = output + this.red;
                }
                else
                {
                    output = output + this.off;
                }
            }

            output = output + " ";

            for (int i = 0; i < 11; i++)
            {
                if (i < (Int32.Parse(times[1]) / 5))
                {
                    if ((i + 1) % 3 == 0)
                        output = output + this.red;
                    else
                        output = output + this.yellow;
                }
                else
                {
                    output = output + this.off;
                }
            }

            output = output + " ";

            for (int i = 0; i < 4; i++)
            {
                if (i < (Int32.Parse(times[1]) % 5))
                {
                    output = output + this.yellow;
                }
                else
                {
                    output = output + this.off;
                }
            }

            return output;
        }
    }
}
