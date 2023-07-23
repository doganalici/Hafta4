using System;

namespace DoWhileOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1, b=1, c;
            do
            {
                a++;
                b++;
                c = a * a + b + b;
                if (c==c)
                {
                    Console.WriteLine($"a = {a} , b = {b} , c = {c}");
                }
            } 
            while (c<50);

            Console.ReadKey();
        }
    }
}
