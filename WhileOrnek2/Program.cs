using System;

namespace WhileOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı tarafından 0 girilene kadar sayıların toplamı ve ortalamasını bulalım
            double sayi, toplam = 0, ortalama,adet=0;
            Console.Write("Bir sayı giriniz : ");
            sayi = Convert.ToDouble(Console.ReadLine());
            while (sayi!=0)
            {
                toplam += sayi;
                adet++;
                Console.Write("Bir sayı giriniz : ");
                sayi = Convert.ToDouble(Console.ReadLine());
            }
            ortalama = toplam / adet;

            Console.WriteLine($"Toplam : {toplam} , Ortalama : {ortalama} , Sayı adeti : {adet}");
            Console.ReadKey();
        }
    }
}
