using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Stewardess: Unit
    {
        public Stewardess()
        {
            len = 1;
            weight = 0;
        }

        public override void addUnit(Unit p, int i)
        {
        }

        public override void deleteUnit(int i)
        {
        }

        public override void info()
        {
            Console.WriteLine("Stewardess");
        }
    }
}