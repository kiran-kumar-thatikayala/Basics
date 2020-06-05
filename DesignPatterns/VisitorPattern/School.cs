using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    public class School
    {
        List<IElement> students;
        public School()
        {
            students = new List<IElement>() 
            {
                new Kid("Kiran"),
                new Kid("Kumar"),
                new Kid("thatikayala")
            };
        }

        public void PerformOperation(IVisitor visitor)
        {
            students.ForEach(kid => kid.Accept(visitor));
            List<String> names = new List<String>();            
        }
    }
}
