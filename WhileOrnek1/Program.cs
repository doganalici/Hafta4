using System;

namespace WhileOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- 0 - 20 arasındaki ardışık sayılar\n");
            int sayac = 0;
            while (sayac <= 20)
            {
                Console.WriteLine(sayac);
                sayac++;
            }

            Console.WriteLine("\n\n---- 0 - 20 arasındaki ardışık çift sayılar\n");
            sayac = 0;
            while (sayac <= 20)
            {
                if (sayac%2==0)
                {
                    Console.WriteLine(sayac);
                }
                sayac++;
            }

             Console.WriteLine("\n\n---- 0 - 20 arasındaki ardışık tek sayılar\n");
            sayac = 1;
            while (sayac <= 20)
            {
                if (sayac%2==1)
                {
                    Console.WriteLine(sayac);
                }
                sayac++;
            }


            Console.ReadKey();
        }
    }
}
