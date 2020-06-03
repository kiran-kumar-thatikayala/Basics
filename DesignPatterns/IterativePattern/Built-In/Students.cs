using System.Collections;
using System.Collections.Generic;

namespace IterativePattern
{
    public class Students : IEnumerable
    {
        private Student[] students;
        public Students(Student[] stds)
        {
            this.students = new Student[stds.Length];
            for (int i = 0; i < stds.Length; i++)
            {
                this.students[i] = stds[i];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new StudentEnumerator(students);
        }
    }
}
