using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IterativePattern
{
    public class StudentEnumerator : IEnumerator
    {
        private readonly Student[] data;
        private  int position =-1;

        public StudentEnumerator(Student[] data)
        {
            this.data = data;
        }
        public object Current => data[position];

        public bool MoveNext()
        {
            position++;
            return position < data.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
