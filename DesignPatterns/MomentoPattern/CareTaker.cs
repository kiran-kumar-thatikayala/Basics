using System;
using System.Collections.Generic;
using System.Text;

namespace MomentoPattern
{
    public class CareTaker<T>
    {
        private List<Momento<T>> momentoList = new List<Momento<T>>();
        public void SaveState(Originator<T> originator)
        {
            momentoList.Add(originator.CreateMemento());
        }
        public void RestoreState(Originator<T> originator, int index)
        {
            if (index > -1)
            {
                Momento<T> momento = momentoList[index];
                originator.SetMomento(momento);
            }
            else
                originator.SetMomento(new Momento<T>());
        }
    }
}
