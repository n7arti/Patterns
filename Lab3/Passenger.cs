using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Passenger : Unit
    {
        public Passenger()
        {
            Random r = new Random();
            len = 1;
            weight = r.Next(5, 61);
            id = r.Next(5000);
        }
        public override void addUnit(Unit p, int i)
        {
        }

        public override void deleteUnit(int i)
        {
        }

        public override void info()
        {
            Console.WriteLine("Passenger " + id);
        }
    }
}