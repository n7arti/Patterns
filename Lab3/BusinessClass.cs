using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class BusinessClass: Unit
    {
        Unit[] mas;

        public BusinessClass()
        {
            len = 20;
            weight = 0;
            maxweight = 35;
            mas = new Unit[len];
        }

        public override void addUnit(Unit p, int i)
        {
            mas[i] = p;
        }
        public override void info()
        {
            Console.WriteLine("Business Class");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Place " + i);
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