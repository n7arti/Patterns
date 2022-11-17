using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class BoardTax: BoardAnyCar
    {
        public BoardTax()
        {
            countPlace = 4;
        }
        public override Driver BoardDriver()
        {
            return new TaxDriver();
        }

        public override Passenger BoardPassenger()
        {
            return new TaxPassenger();
        }
    }
}
