using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Teacher: IObservable, IObserver
    {
        String FIO;
        Performance perf;
        List<IObserver> observers;
        public Teacher(String FIO)
        {
            observers = new List<IObserver>();
            this.FIO = FIO;
            perf = new Performance(FIO);
        }
        public String getFio()
        {
            return FIO;
        }
        public Performance getPerf()
        {
            return perf;
        }

        public void addPerf(bool info)
        {
            perf.setInfo(info);
            NotifyObservers();
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

        public override string ToString()
        {
            return FIO.ToString();
        }

        public void Update(object ob)
        {
            Teacher teacher = (Teacher)ob;
            if (!teacher.getPerf().getInfo())
            {
                Console.WriteLine(teacher.getFio() + " не заполнил успеваемость");
            }
        }
    }
}
