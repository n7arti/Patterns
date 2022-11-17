using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Tab : Interpreter
    {
        public string correct(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if(i>0 & input[i].Equals('\t'))
                    input = input.Substring(0, i) + input.Substring(i+1);
            }
                return input;
        }
    }
}
