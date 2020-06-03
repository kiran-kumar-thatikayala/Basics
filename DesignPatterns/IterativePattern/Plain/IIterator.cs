using System;
using System.Collections.Generic;
using System.Text;

namespace IterativePattern
{
    public interface IIterator
    {
        string First { get; }
        string Next { get; }
        string Current { get; }

        bool IsDone { get; }
    }
}
