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


            System.Console.WriteLine("\n********* Testing double dispatch *********\n");

            System.Console.WriteLine("\n failure scenario \n");
            App app = new App();
            app.Export(new Rectangle());
            app.Export(new Sqaure());
            app.Export(new Circle());



            System.Console.WriteLine("\n sucess scenario \n");
            app.Export2(new Rectangle());
            app.Export2(new Sqaure());
            app.Export2(new Circle());


        }
    }

  
}
