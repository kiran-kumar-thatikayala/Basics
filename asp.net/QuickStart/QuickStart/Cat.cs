using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickStart
{
    public class Cat
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual char Sex { get; set; }

        public virtual float Weight { get; set; }
    }
}