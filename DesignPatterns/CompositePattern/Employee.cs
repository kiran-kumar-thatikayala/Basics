namespace CompositePattern
{
    partial class Program
    {
        public abstract class Employee
        {
            public string Name { set; get; }
            public abstract void AddEmployee(Employee emp);
            public abstract void PerformanceReview();
        }
    }
}
