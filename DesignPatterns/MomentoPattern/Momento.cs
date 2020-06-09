using System;
using System.Collections.Generic;
using System.Text;

namespace MomentoPattern
{
    public class Momento<T>
    {
        private T state;

        public T GetState()
        {
            return state;
        }

        public void SetState(T state)
        {
            this.state = state;
        }
    }
}
