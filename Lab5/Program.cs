using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "“a‐b  c”\t ( ab )\n\na , b .\n";
            Console.WriteLine("Ввод:\n" + input);
            MyIntepreteter intepreteter = new MyIntepreteter();
            input = intepreteter.interpetet(input);
            Console.WriteLine("Вывод:\n"+input);
        }
    }
}
