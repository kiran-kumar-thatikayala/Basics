using System;
using System.Collections.Generic;
using System.Text;

namespace MomentoPattern
{
    public class Originator<T>
    {
        private T state;

        public void SetState(T state)
        {
            this.state = state;
        }

        public T GetState()
        {
                return state;
        }

        public Momento<T> CreateMemento()
        {
            Momento<T> momento = new Momento<T>();
            momento.SetState(state);
            return momento;
        }

        public void SetMomento(Momento<T> momento)
        {
            state = momento.GetState();
        }
    }
}
