using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class BoardOutOfTownBus : BoardAnyCar
    {
        public BoardOutOfTownBus()
        {
            countPlace = 30;
        }
        public override Passenger BoardAdult()
        {
            PutLuggage();
            SetChildChair();
            return new Adult();
        }

        public override Passenger BoardBeneficiary()
        {
            PutLuggage();
            SetChildChair();
            return new Adult();
        }

        public override Passenger BoardChild()
        {
            PutLuggage();
            SetChildChair();
            return new Child();
        }

        public override Driver BoardDriver()
        {
            
            return new BusDriver();
        }

        public override void CheckTravel(string s)
        {
        }

        public override void PutLuggage()
        {
            Console.WriteLine("Luggage is laid");
        }

        public override void SetChildChair()
        {
            Console.WriteLine("Passenger is wearing a seatbelt");
        }
    }
}