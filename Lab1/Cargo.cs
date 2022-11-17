using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Cargo: Passenger
    {
        public override void Info()
        {
            Console.WriteLine("Cargo " + id);
        }
    }
}
