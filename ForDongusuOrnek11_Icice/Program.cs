using System;

namespace ForDongusuOrnek11_Icice
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"({i}, {j})");
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
