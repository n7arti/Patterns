using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            BoardBus bus1 = new BoardBus();
            BoardTax tax = new BoardTax();
            BoardOutOfTownBus bus2 = new BoardOutOfTownBus();

            Storage allb1 = board.boardAll(bus1);
            Storage allb2 = board.boardAll(bus2);
            Storage allt = board.boardAll(tax);
            
            Console.WriteLine("Bus 1:");
            allb1.Info();
            Console.WriteLine("Bus 2:");
            allb2.Info();
            Console.WriteLine("Tax:");
            allt.Info();
        }
    }
}
