using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class EconomyClass : Unit
    {
        Unit[] mas;
        public EconomyClass()
        {
            len = 150;
            weight = 0;
            maxweight = 20;
            mas = new Unit[len];
        }
        public override void addUnit(Unit p, int i)
        {
            mas[i] = p;
        }
        public override void info()
        {
            Console.WriteLine("Economy Class");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Place "+i);
                mas[i].info();
            }
        }
        public void deleteLuggage(int i)
        {
            weight -= mas[i].weight;
            mas[i].weight = 0;
            Console.WriteLine("Passenger " + mas[i].id + " luggage removed from flight");
        }

        public override void deleteUnit(int i)
        {
            Console.WriteLine("Passenger " + mas[i].id + " removed");
            weight -= mas[i].weight;
            mas[i] = null;
        }
    }
}