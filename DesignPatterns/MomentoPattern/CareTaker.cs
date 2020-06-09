using System;
using System.Collections.Generic;
using System.Text;

namespace MomentoPattern
{
    public class CareTaker<T>
    {
        private List<Momento<T>> momentoList = new List<Momento<T>>();
        public void SaveMomento(Momento<T> momento)
        {
            momentoList.Add(momento);
        }
        public Momento<T> GetMomento(int index)
        {
            if (index > -1)
            {
                return momentoList[index];
            }
            else
                return new Momento<T>();
        }
    }
}
