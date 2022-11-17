using System;
using System.Collections.Generic;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IObservable> teach =  new List<IObservable>();
            Teacher teacher1 = new Teacher("Романов Алексей Дмитриевич");
            Teacher teacher2 = new Teacher("Куськов Кусь Куськович");
            teach.Add(teacher1);
            teach.Add(teacher2);
            Decanat decanat = new Decanat(teach);



            foreach (Teacher o in teach)
            {
                if(o.getFio().Equals("Куськов Кусь Куськович")) 
                    o.addPerf(false);
                else o.addPerf(true);
            }

            teacher2.RemoveObserver(decanat);

            foreach (Teacher o in teach)
            {
                if (o.getFio().Equals("Куськов Кусь Куськович"))
                    o.addPerf(false);
                else o.addPerf(true);
            }
        }
    }
}
