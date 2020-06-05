using System;

namespace VisitorPattern
{
    public class DoctorVisitor : IVisitor
    {
        public void Visit(Kid kid)
        {
            Console.WriteLine($"doctor visited kid {kid.Name}");
        }

        public void Visit(Teacher kid)
        {
            Console.WriteLine($"doctor visited teacher {kid.Name}");
        }
    }
}
