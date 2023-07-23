using System;

namespace ForDongusuOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine(i);
            Console.WriteLine("--------------------\n");

            int j;
            for (j = 0; j < 10;)
            {
                Console.Write(j + ",");
                j++;
            }
            Console.WriteLine("\n\n--------------------\n");

            for (int k = 0; ;)
            {
                Console.Write(k + ",");
                ++k;
                if (k == 10)
                {
                    break;
                }
            }
            Console.WriteLine("\n\n--------------------\n");
            Console.WriteLine("Negatif artış miktarı\n");
            for (int m = 10; m > 0; m--)
            {
                Console.Write(m + ",");
            }

            Console.WriteLine("\n\n--------------------\n");
            for (int m = 100; m > 0; m -= 2)
            {
                Console.Write(m + ",");
            }

            Console.WriteLine("\n\n--------------------\n");
            for (int m = 100; m > 0; m /= 2)
            {
                Console.Write(m + ",");
            }

            Console.ReadKey();
        }
    }
}
