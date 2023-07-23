using System;

namespace WhileOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, sonuc = 0;
            Console.Write("Bir sayı giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\n\nGirilen sayı : {sayi}, ");
            while (sayi > 0)
            {
                sonuc += (sayi % 10);
                sayi /= 10;
            }
            Console.Write($" Rakamları Toplamı : {sonuc}");

            Console.ReadKey();
        }
    }
}
