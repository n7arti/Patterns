using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
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
        public override Passenger BoardAdult()
        {
            CheckTravel("Adult");
            return new Adult();
        }

        public override Passenger BoardChild()
        {
            CheckTravel("Child");
            return new Child();
        }

        public override Passenger BoardBeneficiary()
        {
            CheckTravel("Beneficiary");
            return new Beneficiary();
        }

        public override void CheckTravel(string s)
        {
            Console.WriteLine(s + " got on the bus");
        }

        public override void SetChildChair()
        {
        }

        public override void PutLuggage()
        {
        }
    }
}
