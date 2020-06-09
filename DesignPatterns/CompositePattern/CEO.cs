using System;
using System.Collections.Generic;

namespace CompositePattern
{
    partial class Program
    {
        public class CEO : Employee
        {
            List<Employee> directors;
            public CEO(string name)
            {
                this.Name = name;
                directors = new List<Employee>();
            }
            public CEO()
            {
                directors = new List<Employee>();
            }
            public override void AddEmployee(Employee emp)
            {
                directors.Add(emp);
            }

            public override void PerformanceReview()
            {
                Console.WriteLine($"CEO performance reviewed for {Name}");

                foreach (var director in directors)
                {
                    director.PerformanceReview();
                }
            }
        }
    }
}
