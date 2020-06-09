using System;
using System.Collections.Generic;
using System.Text;

namespace MomentoPattern
{
    public class Originator
    {
        private string text;

        public void SetText(string text)
        {
            this.text = text;
        }

        internal Momento<string> StoreInMomento()
        {
            Momento<string> momento = new Momento<string>();
            momento.State = this.text;
            return momento;
        }

        internal string RestoreFromMomento(Momento<string> momento)
        {
            return momento.State;
        }
    }
}
