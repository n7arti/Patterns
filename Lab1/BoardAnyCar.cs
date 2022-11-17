using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    abstract class BoardAnyCar
    {
        public int countPlace;
        public abstract Driver BoardDriver();
        public abstract Passenger BoardPassenger();
    }
}
