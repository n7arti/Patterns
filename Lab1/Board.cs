using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Board
    { 
        public Storage boardAll(BoardAnyCar board)
        {
            Storage all = new Storage();
            all.dr.Add(board.BoardDriver());
            while(all.ps.Count< board.countPlace)
                all.ps.Add(board.BoardPassenger());
            return all;
        }
    }
}
