using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class TaxDriver: Driver
    {
       
        public override void Info()
        {
            Console.WriteLine("Tax Driver " + id);
        }
    }
}
