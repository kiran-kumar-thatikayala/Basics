using System;

namespace CompositePattern
{
    partial class Program
    {
        public class Developer : Employee
        {
            public Developer(string name)
            {
                this.Name = name;
            }
            public override void AddEmployee(Employee emp)
            {
                throw new NotImplementedException();
            }

            public override void PerformanceReview()
            {
                Console.WriteLine($"Developer performance reviewed for {Name}" );               
            }
        }
    }
}
