﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class BusDriver: Driver
    {
        public override void Info()
        {
            Console.WriteLine("Bus Driver " + id);
        }
    }
}
