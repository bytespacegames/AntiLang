using System;

namespace AntiLang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter AntiLang code here: ");
            string inp = Console.ReadLine();

            Console.Write("\n");

            foreach(char c in inp)
            {
                switch (c)
                {
                    case 'a':
                        Console.Write("sus");
                        break;
                    case 'b':
                        Console.Write("amogus");
                        break;
                    case 'c':
                        Console.Write("\n");
                        break;
                }
            }
        }
    }
}
