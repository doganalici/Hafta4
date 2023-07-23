using System;

namespace ForDongusuOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 - 100 aralığındaki ardışık sayılar
            Console.WriteLine("0 - 100 aralığında ardışık sayılar");
            for (int i = 0; i <= 100; i++)
            {
                Console.Write(i + ",");
            }

            //0 - 100 aralığındaki çift sayılar
            Console.WriteLine("\n\n0 - 100 aralığında ardışık çift sayılar");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ",");
                }
            }

            //0 - 100 aralığındaki tek sayılar
            Console.WriteLine("\n\n0 - 100 aralığında ardışık tek sayılar");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + ",");
                }
            }

            //0 - 100 aralığındaki 5 in katı ardışık sayılar
            Console.WriteLine("\n\n0 - 100 aralığında 5 in katı ardışık sayılar");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + ",");
                }
            }

            //0 - 100 aralığındaki 6 nın katı ardışık sayılar
            Console.WriteLine("\n\n0 - 100 aralığında 6 nın katı ardışık sayılar");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.Write(i + ",");
                }
            }

            //0 - 100 aralığındaki 5 in katı fakat çift olmayan ardışık sayılar
            Console.WriteLine("\n\n0 - 100 aralığında 5 in katı fakat çift olmayan ardışık sayılar");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 2 != 0)
                {
                    Console.Write(i + ",");
                }
            }

            Console.ReadKey();
        }
    }
}
