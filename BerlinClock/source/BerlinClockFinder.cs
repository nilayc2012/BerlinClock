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

            public BerlinClockFinder(string red,string yellow,string off)
            {
                this.red = red;
                this.yellow = yellow;
                this.off = off;
            }


            override public string formatToBerlinClock(string time)
            {
                string[] times;

            //delimitter for the parsing of time values
                char[] delimitter = { ':' };

            //checking the case of 12 hour format if time is PM
                if (time.ToLower().Contains("pm")|| time.ToLower().Contains("p"))
                {
                    time=time.Replace("PM", "");
                    time=time.Replace("pm", "");
                    time=time.Trim();

                    times = time.Split(delimitter,3);

                //in case of time format not correct
                    if (times.Length != 3) {
                        return "Unsupported input format";
                    }

                    // Following 3 If conditions for checking if the input string is containing other than the time info. Then we discard the rest of the data
                    if (times[1].Length > 2)
                    {
                        time.Remove(0, time.IndexOf(":") + 1);
                        times = time.Split(delimitter, 3);
                    }

                    if (times[0].Length > 2)
                    {
                        times[0] = times[0].Substring(times[0].Length - 2);
                    }
                    if (times[2].Length > 2)
                    {
                        times[2] = times[2].Substring(0, 2);
                    }

                    //In 12 hour format we are converting it to 24 hour format to support berlin clock format
                    if(Int32.Parse(times[0])!=12)
                    times[0] = (Int32.Parse(times[0]) + 12).ToString();

                
                }
                else
                {   //In case of 12 HR format as well as 14 HR format
                    bool amFlag = false;
                    if (time.ToLower().Contains("am")|| time.ToLower().Contains("a"))
                    {
                        amFlag = true;
                    }

                    time=time.Replace("AM", "");
                    time=time.Replace("am", "");
                    time=time.Trim();

                    times = time.Split(delimitter,3);


                    if (times.Length != 3)
                    {

                         return "Unsupported input format";

                    }

                    if (times[1].Length > 2)
                    {
                        time=time.Remove(0, time.IndexOf(":") + 1);
                        times = time.Split(delimitter, 3);
                    }

                    if (times[0].Length > 2)
                    {
                        times[0] = times[0].Substring(times[0].Length - 2);
                    }
                    if (times[2].Length > 2)
                    {
                        times[2] = times[2].Substring(0, 2);
                    }

                    if (amFlag)
                    {
                        if (Int32.Parse(times[0]) == 12)
                            times[0] = "0";
                    }
                }


                String output = null;
            
            //for the first blinking light in berlin clock
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

            //for the 1st row in berlin clock
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
            //for the 2nd row
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
            //3rd row
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
            //forth row
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

            //overloaded method for Datetime as parameter
            public string formatToBerlinClock(DateTime dtime)
            {
                string time=dtime.ToString("HH:mm:ss");
                return formatToBerlinClock(time);
            }

            //overloaded method for hour,minute and second string values as parameter
            public string formatToBerlinClock(string hour,string minute,string second)
            {
                int n;
                if(!int.TryParse(hour,out n)|| !int.TryParse(minute, out n)|| !int.TryParse(second, out n))
                {
                    return "wrong input format";
                }
                else if(!((Int32.Parse(hour)>=0)&&(Int32.Parse(hour) <=24))||!((Int32.Parse(minute) >= 0) && (Int32.Parse(minute) <= 60))||!((Int32.Parse(second) >= 0) && (Int32.Parse(second) <= 60)))
                {
                    return "wrong input format";
                }
                string time = hour + ":" + minute + ":" + second;
                return formatToBerlinClock(time);
            }

        //overloaded method for hour,minute and second integer values as parameter
        public string formatToBerlinClock(int hour, int minute, int second)
            {
                string time = hour + ":" + minute + ":" + second;
                return formatToBerlinClock(time);
            }
        }
    }
