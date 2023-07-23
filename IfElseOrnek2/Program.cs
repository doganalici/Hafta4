using System;

namespace IfElseOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //üçgenin tüm kenarları aynı uzunlukta ise : Eşkenar
            //üçgenin tüm kenarları farklı uzunlukta ise : Çeşitkenar
            //üçgenin iki kenarı aynı uzunlukta ise : İkizkenar

            int a, b, c;
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());


            if (a==b && a==c)
            {
                Console.WriteLine("Eşkenar üçgen");
            }
            else if (a!=b && a!=c && b!=c)
            {
                Console.WriteLine("Çeşitkenar üçken");
            }
            else
            {
                Console.WriteLine("İkizkenar üçgen");
            }
            Console.ReadKey();
        }
    }
}
