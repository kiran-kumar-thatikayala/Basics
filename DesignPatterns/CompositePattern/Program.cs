using System;

namespace CompositePattern
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Employee dev1 = new Developer("Kiran");
            Employee dev2 = new Developer("Bhaskar");

            Employee manager = new Manager("Vaibhav");
            manager.AddEmployee(dev1);
            manager.AddEmployee(dev2);

            Employee director1 = new Director("Brian");
            director1.AddEmployee(manager);

            dev1 = new Developer("Viswa");
            dev2 = new Developer("Anil");

            manager = new Manager("Narasimha");
            manager.AddEmployee(dev1);
            manager.AddEmployee(dev2);

            Director director2 = new Director("Mike");
            director2.AddEmployee(manager);

            Employee ceo = new CEO();
            ceo.AddEmployee(director1);
            ceo.AddEmployee(director2);

            ceo.PerformanceReview();
        }
    }
}
