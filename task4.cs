using System;

namespace taskfour
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 19999;
            if (a > 0 && a <= 9)
            {
                Console.WriteLine("1 reqemlidir");
            }
            else if (a > 9 && a <= 99)
            {
                Console.WriteLine("2 reqemlidir");
            }
            else if (a > 9999 && a <= 99999)
            {
                Console.WriteLine("5 reqemlidir");
            }
        }
    }
}
