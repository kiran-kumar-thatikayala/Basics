using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Teacher:IElement
    {
        public Teacher(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
