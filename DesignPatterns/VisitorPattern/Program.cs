using System.Linq;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            school.PerformOperation(new SalesmanVisitor());
            school.PerformOperation(new DoctorVisitor());
        }
    }
}
