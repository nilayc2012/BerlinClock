using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.source
{

    abstract class BerlinClockFinderParent<T>
    {
        protected string red;
        protected string yellow;
        protected string off;

        public BerlinClockFinderParent()
        {
            red = "R";
            yellow = "Y";
            off = "O";
        }

        public abstract T formatToBerlinClock(string time);
    }
}
