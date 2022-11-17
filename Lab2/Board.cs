using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Board
    { 
        public Storage boardAll(BoardAnyCar board)
        {
            Storage all = new Storage();
            all.dr.Add(board.BoardDriver());
            while (all.ps.Count+3 <= board.countPlace)
            {
                all.ps.Add(board.BoardChild());
                all.ps.Add(board.BoardAdult());
                all.ps.Add(board.BoardBeneficiary());
            }
            Console.WriteLine("\nBoard completed \n\n");
            return all;
        }
    }
}
