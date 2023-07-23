using System;

namespace DoWhileOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı tarafından 0 girilene kadar sayıların toplamı ve ortalamasını bulalım
            double sayi, toplam = 0, ortalama, adet = 0;

            do
            {
                Console.Write("Bir sayı giriniz : ");
                sayi = Convert.ToDouble(Console.ReadLine());
                toplam += sayi;
                if (sayi != 0)
                {
                    adet++;
                }
            }
            while (sayi != 0);

            ortalama = toplam / adet;

            Console.WriteLine($"Toplam : {toplam} , Ortalama : {ortalama} , Sayı adeti : {adet}");
            Console.ReadKey();
        }
    }
}
