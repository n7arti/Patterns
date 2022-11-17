using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class BoardBus: BoardAnyCar
    {
        public BoardBus()
        {
            countPlace = 30;
        }
        public override Driver BoardDriver()
        {
            return new BusDriver();
        }
        public override Passenger BoardPassenger()
        {
            return new BusPassenger();
        }
    }
}
