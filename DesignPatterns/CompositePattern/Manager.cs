using System;
using System.Collections.Generic;

namespace CompositePattern
{
    partial class Program
    {
        public class Manager : Employee
        {
            private List<Employee> developer;
            public Manager(string name)
            {
                this.Name = name;
                developer = new List<Employee>();
            }

            public override void AddEmployee(Employee emp)
            {
                developer.Add(emp);
            }

            public override void PerformanceReview()
            {
                Console.WriteLine($"Manager performance reviewed for {Name}");

                foreach (var dev in developer)
                {
                    dev.PerformanceReview();
                }
            }
        }
    }
}
