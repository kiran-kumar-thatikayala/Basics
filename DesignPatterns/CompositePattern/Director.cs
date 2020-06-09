using System;
using System.Collections.Generic;

namespace CompositePattern
{
    partial class Program
    {
        public class Director : Employee
        {
            private List<Employee> managers;

            public Director(string name)
            {
                this.Name = name;
                managers = new List<Employee>();
            }
            public override void AddEmployee(Employee emp)
            {
                managers.Add(emp);
            }

            public override void PerformanceReview()
            {
                Console.WriteLine($"Director performance reviewed for {Name}");

                foreach (var manager in managers)
                {
                    manager.PerformanceReview();
                }
            }
        }
    }
}
