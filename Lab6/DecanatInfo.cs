using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class DecanatInfo: IObservable
    {
        bool fill;
        List<IObserver> observers;
        public DecanatInfo(bool fill)
        {
            this.fill = fill;
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(this);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o); ;
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
    }
}
