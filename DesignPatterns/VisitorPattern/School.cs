using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    public class School
    {
        List<IElement> persons;
        public School()
        {
            persons = new List<IElement>()
            {
                new Kid("Kiran"),
                new Kid("Kumar"),
                new Kid("thatikayala"),
                new Teacher("sudhakar"),
                new Teacher("Ravi")
            };
        }

        public void PerformOperation(IVisitor visitor)
        {            
            //persons.ForEach(person => visitor.Visit(person));
            //the above fails hence double dispatch
            persons.ForEach(person => person.Accept(visitor));

        }
    }
}
