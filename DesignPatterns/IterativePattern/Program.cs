using IterativePattern;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] peopleArray = new Student[3]
           {
                new Student("John", "Smith"),
                new Student("Jim", "Johnson"),
                new Student("Sue", "Rabon"),
           };

            Students peopleList = new Students(peopleArray);
            foreach (Student p in peopleList)
                Console.WriteLine(p.FirstName + " " + p.LastName);
        }
    }
}
