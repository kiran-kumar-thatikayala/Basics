using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("light on");
        }

        public void Off()
        {
            Console.WriteLine("light off");
        }
    }
}