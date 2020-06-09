using System;
using System.Collections.Generic;
using System.Text;

namespace MomentoPattern
{
    public class Momento<T>
    {
        public T State { set; get; }
    }
}
