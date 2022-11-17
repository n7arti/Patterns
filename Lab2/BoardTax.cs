using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
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

        public override Passenger BoardAdult()
        {
            return new Adult();
        }

        public override Passenger BoardChild()
        {
            SetChildChair();
            return new Child();
        }

        public override void SetChildChair()
        {
            Console.WriteLine("Set child chair");
        }

        public override Passenger BoardBeneficiary()
        {
            return new Adult();
        }

        public override void CheckTravel(string s)
        {
        }

        public override void PutLuggage()
        {
        }
    }
}
