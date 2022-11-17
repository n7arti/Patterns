using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Space : Interpreter
    {
        public string correct(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if ((input[i].Equals('(') & (input[i + 1].Equals(' '))))
                    input = input.Substring(0, i + 1) + input.Substring(i + 2);
                if ((input[i].Equals(' ') & (input[i + 1].Equals(')'))))
                    input = input.Substring(0, i) + input.Substring(i + 1);
                if ((input[i].Equals(' ') & (input[i + 1].Equals(','))))
                {
                    input = input.Substring(0, i) + input.Substring(i + 1);
                }
                if ((input[i].Equals(' ') & (input[i + 1].Equals('.'))))
                    input = input.Substring(0, i) + input.Substring(i + 1);
            }
            return input;
        }

    }
}
