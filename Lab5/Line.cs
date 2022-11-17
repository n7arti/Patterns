using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Line : Interpreter
    {
        public string correct(string input)
        {
            char c = (char)0x0A;
            for (int i = 0; i < input.Length - 1; i++)
            {
                
                if ((input[i].Equals(c) ))
                {
                    Console.WriteLine("t");
                    input = input.Substring(0, i) + input.Substring(i + 1);
                }
            }
            return input;
        }
    }
}
