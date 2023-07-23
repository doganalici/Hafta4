using System;

namespace ForDongusuOrnek4_SonsuzDongu
{
    class Program
    {
        static void Main(string[] args)
        {
            //sonsuz for döngüleri

            Console.WriteLine("sonsuz döngüler");
            //for (; ; )
            //{
            //    Console.WriteLine("Sonsuz Döngü");
            //}

            //for (int i = 0; ;)
            //{
            //    Console.WriteLine("Sonsuz Döngü");
            //}

            //for (int i = 0; i < 10;)
            //   {
            //       Console.WriteLine("Sonsuz Döngü");
            //   }

            //for (int i = 0; i < 10; i--)
            //{
            //    Console.WriteLine("Sonsuz Döngü");
            //}

            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("Sonsuz Döngü");
            }

            Console.ReadKey();
        }
    }
}
