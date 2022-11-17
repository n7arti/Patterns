using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class MyIntepreteter
    {
        TwoSpace twoSpace = new TwoSpace();
        Defis defis = new Defis();
        Quotes quotes = new Quotes();
        Space space = new Space();
        Tab tab = new Tab();
        Line line = new Line();
        public string interpetet(string input)
        {
            input = twoSpace.correct(input);
            input = defis.correct(input);
            input = quotes.correct(input);
            input = space.correct(input);
            input = tab.correct(input);
            input = line.correct(input);
            return input;
        }
    }
}
