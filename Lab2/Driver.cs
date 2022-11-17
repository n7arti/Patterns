using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    abstract class Driver
    {
        public int id;
        public Driver()
        {
            id = new Random().Next(5000);
        }
        public abstract void Info();
    }
}
