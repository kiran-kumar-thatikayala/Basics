using System;
using System.Collections.Generic;

namespace IterativePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Weeks weeks = new Weeks();
            weeks[0] = "Sunday";
            weeks[1] = "Monday";
            weeks[2] = "Tuesday";
            weeks[3] = "Wednessday";
            weeks[4] = "Thursday";
            weeks[5] = "Friday";
            weeks[6] = "Saturday";

            IIterator iterator = weeks.GetIterator();
            for (string s = iterator.First; iterator.IsDone == false; s = iterator.Next)
            {
                Console.WriteLine(s);
            }
        }
    }
}
