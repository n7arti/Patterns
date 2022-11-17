using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class BoardTrain: BoardAnyCar
    {
        public BoardTrain()
        {
            countPlace = 10;
        }
        public override Driver BoardDriver()
        {
            return new TrainDriver();
        }

        public override Passenger BoardPassenger()
        {
            return new Cargo();
        }
    }
}
