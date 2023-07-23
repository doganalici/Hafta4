using System;

namespace ForDongusuOrnek10_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 0 - 100 aralığında ardışık çift sayılar");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.Write(i + ", ");
            }

            Console.WriteLine("\n\n--- 0 - 100 aralığında ardışık tek sayılar");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.Write(i + ", ");
            }


            Console.WriteLine("\n\n--- 0 - 100 aralığında ardışık tek sayılar");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + ", ");
                }
                continue;
            }
            Console.ReadKey();
        }
    }
}
