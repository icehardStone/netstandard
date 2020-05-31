using System;
using System.Threading.Tasks;
using System.Threading;

namespace   sample_event
{
    public class EventTest
    {
        public event EventHandler ThrowHolder;
        public int Length {set;get;}
        public int Total {set;get;}
        public int[] Objs {set;get;}
        public EventTest()
        {
            this.Length = 0;
            this.Total = 0;
            this.Objs = new int[100];
        }
        public void Add(int val)
        {
            OnThrowHolder(val,EventArgs.Empty);
        }
        protected virtual void OnThrowHolder(object obj, EventArgs e)
        {
            int val = (int)obj;
            this.Length += 1;
            this.Objs[Length-1] = val;
            this.Total += val;

            EventHandler handler = ThrowHolder;
            handler?.Invoke(handler,e);
        }
    }
}