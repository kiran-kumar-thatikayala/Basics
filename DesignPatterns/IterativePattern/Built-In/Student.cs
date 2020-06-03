namespace IterativePattern
{
    public class Student
    {
        public Student(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}