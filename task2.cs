using System;

namespace tasktwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            if (a%2 ==0 && a%3 ==0)
            {
                Console.WriteLine("3 e bolunen cut ededdir");
            }
            else if (a%3 ==0)
            {
                Console.WriteLine("3 e bolunen tek ededdir");
            }
            else
            {
                Console.WriteLine("3 e bolunmur");
            }
        }
    }
}
