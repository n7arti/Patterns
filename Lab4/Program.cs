using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int n = 0;
            Console.WriteLine("Щелк мышкой (х,у)... ");
            x =Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            Box b = new Box(x, y);
            b.draw();
            while (n!=3)
            {
                Console.WriteLine("1:Двойной щелчок мышкой    2:Переместить    3:Выход");
                n = Int32.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            b.setClick(!b.getClick());
                            b.draw();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Щелк мышкой (х,у)... ");
                            x = Int32.Parse(Console.ReadLine());
                            y = Int32.Parse(Console.ReadLine());
                            b.move(x, y);
                            break;
                        }
                }
            }
        }
    }
}
