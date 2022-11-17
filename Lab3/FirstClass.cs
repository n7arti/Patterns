using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class FirstClass : Unit
    {
        Unit[] mas;

        public FirstClass()
        {
            len = 10;
            weight = 0;
            maxweight = 60;
            mas = new Unit[len];
        }
        public override void addUnit(Unit p, int i)
        {
            mas[i] = p;
        }
        public override void info()
        {
            Console.WriteLine("First Class");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Place " + i);
                if (mas[i] == null)
                    Console.WriteLine("null");
                else
                    mas[i].info();
            }
        }
        public override void deleteUnit(int i)
        {
            Console.WriteLine("Passenger " + mas[i].id + " removed");
            weight -= mas[i].weight;
            mas[i] = null;
        }
    }
}