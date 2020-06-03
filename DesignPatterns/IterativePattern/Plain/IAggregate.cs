using System;
using System.Collections.Generic;
using System.Text;

namespace IterativePattern
{
    public interface IAggregate
    {
        IIterator GetIterator();
        string this[int index] { set;get; }
        int Count { get; }
    }
}
