using System;

namespace praktika
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 100;
            int c = a + b;
            if (c > 9 && c < 100)
            {
                Console.WriteLine("cem iki reqemli ededdir");
            }
            else if (c > 99 && c < 1000)
            {
                Console.WriteLine("cem uc reqemli ededdir");
            }
            else
            {
                Console.WriteLine("nezere alinmayib");
            }

         
        }
    }
}
