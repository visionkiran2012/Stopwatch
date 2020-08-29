using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch_Assignment
{
    class Program
    {

        public class  Stopwatch
        {
            private DateTime startTime;
            //private DateTime stopTime;
            //private TimeSpan duration;
            public DateTime StartTime()
            {
                startTime = DateTime.Now;
                return startTime;
            }

                           
        }
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            int input1;
            DateTime starTime;
            DateTime endTime;
            double duration;
            int counter = 0;

            while (true)
            {
                Console.Write("1-Start Timer\n2-Stop Timer\n");
                    input1 = Convert.ToInt32(Console.ReadLine());
                if (input1 == 1)
                {
                    starTime = stopwatch.StartTime();
                    counter = 1;
                }
                else
                {
                    throw (new InvalidOperationException("Please Start the timer with 1"));

                }
                 Console.WriteLine("Please enter '2' to stop the timer whenever you want");
                input1 = Convert.ToInt32(Console.ReadLine());
                if (input1==2)
                {
                    endTime = stopwatch.StartTime();
                    counter = 0;

                }
                else
                {
                    throw (new InvalidOperationException("Please end the timer with 2 "));

                }
                if (counter==1)
                {
                    throw (new InvalidOperationException("Stuff"));

                }

                duration = (endTime - starTime).TotalSeconds;
                if (duration>60.0)
                {
                    duration = (endTime - starTime).TotalMinutes;
                    Console.WriteLine(duration+"m");
                }
                else
                {
                    Console.WriteLine(duration+"s");
                }
                }
            }
        }
    }

