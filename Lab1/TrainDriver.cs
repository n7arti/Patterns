using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class TrainDriver: Driver
    {
        public override void Info()
        {
            Console.WriteLine("Train Driver " + id);
        }
    }
}
