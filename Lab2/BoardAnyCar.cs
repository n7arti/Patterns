using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    abstract class BoardAnyCar
    {
        public int countPlace;
        public abstract Driver BoardDriver();
        public abstract Passenger BoardAdult();
        public abstract Passenger BoardChild();
        public abstract Passenger BoardBeneficiary();
        public abstract void SetChildChair();
        public abstract void CheckTravel(string s);
        public abstract void PutLuggage();

    }
}
