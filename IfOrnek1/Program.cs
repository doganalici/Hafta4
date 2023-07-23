using System;

namespace IfOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı tarafından girilen sayının 
            //negatif ya da pozitif olup olmadığını bulalım.

            int sayi;
            Console.Write("Bir sayı giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi<0)
            {
                Console.WriteLine("Sayı negatiftir.");
            }
            else if (sayi==0)
            {
                Console.WriteLine("Sayı sıfırdır");
            }
            else
            {
                Console.WriteLine("Sayı pozitiftir.");
            }

            //girilen sayının tek mi çift mi olduğunu bulalım
            if (sayi%2==0)
            {
                Console.WriteLine("Çift sayı");
            }
            else
            {
                Console.WriteLine("Tek sayı");
            }

            Console.ReadKey();
        }
    }
}
