using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    abstract class Passenger
    {
        public int id;
        public Passenger()
        {
            id = new Random().Next(5000);
        }
        public virtual void Info()
        {
            Console.WriteLine("Passenger " + id);
        }
    }

}
