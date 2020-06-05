using System;

namespace VisitorPattern
{
    public class SalesmanVisitor : IVisitor
    {
        public void Visit(Kid kid)
        {
            Console.WriteLine($"sales man visited kid {kid.Name}");
        }

        public void Visit(Teacher kid)
        {
            Console.WriteLine($"sales man visited teacher {kid.Name}");

        }
    }
}
