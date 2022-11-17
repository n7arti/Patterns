using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            BoardBus bus1 = new BoardBus();
            BoardTax tax = new BoardTax();
            BoardBus bus2 = new BoardBus();
            BoardTrain train = new BoardTrain();

            Storage allb1 = board.boardAll(bus1);
            Storage allt = board.boardAll(tax);
            Storage allb2 = board.boardAll(bus2);
            Storage alltr = board.boardAll(train);

            Console.WriteLine("Bus 1:");
            allb1.Info();
            Console.WriteLine("Bus 2:");
            allb2.Info();
            Console.WriteLine("Tax:");
            allt.Info();

            Console.WriteLine("Train:");
            alltr.Info();

        }
    }
}
