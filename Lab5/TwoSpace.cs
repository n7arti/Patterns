using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class TwoSpace : Interpreter
    {
        public string correct(string input)
        {
            for(int i = 0; i<input.Length-1; i++) {
                if ((input[i].Equals(' ') & (input[i+1].Equals(' '))))
                    input = input.Substring(0, i+1) + input.Substring(i + 2);
            }
            return input;
        }
    }
}
