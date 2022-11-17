using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Decanat : IObserver
    {
        List<IObservable> teacher;
        public Decanat(List<IObservable> obs)
        {
            teacher = new List<IObservable>();
            teacher = obs;
            foreach (IObservable o in teacher)
            {
                o.RegisterObserver(this);
            }
            
        }

        public void Update(object ob)
        {
            Teacher teacher = (Teacher)ob;
            if (!teacher.getPerf().getInfo())
            {
                Console.WriteLine(teacher.getFio() + " не заполнил успеваемость");
                
            }
            else Console.WriteLine(teacher.getFio() + " заполнил успеваемость");
        }
    }
}
