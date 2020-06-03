using System;
using System.Collections.Generic;
using System.Text;

namespace IterativePattern
{
    public class Weeks : IAggregate
    {
        IList<string> weeks;
        public Weeks()
        {
            weeks = new List<string>();
        }

        public string this[int index]
        {
            get
            {
                if (index > Count)
                {
                    return string.Empty;
                }
                else
                {
                    return weeks[index];
                }
            }

            set => weeks.Add(value);
        }

        public int Count => weeks.Count;

        public IList<string> GetWeeks()
        {
            return weeks;
        }

        public IIterator GetIterator()
        {
            return new Iterator(this);
        }
    }
}
