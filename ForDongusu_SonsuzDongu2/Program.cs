using System;

namespace ForDongusu_SonsuzDongu2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı tarafından sıfır girilene kadar
            //girilen sayıları toplamı ve ortalamasını bulalım

            double sayi, toplam = 0, ortalama, sayac = 0;

            for (; ; )
            {
                Console.Write("Bir sayı giriniz : ");
                sayi = Convert.ToDouble(Console.ReadLine());
                if (sayi == 0)
                {
                    break;
                }
                else
                {
                    toplam += sayi;
                    sayac++;
                }

            }
            ortalama = toplam / sayac;
            Console.WriteLine($"Sayıların Adedi : {sayac} , Toplam : {toplam} , Ortalama : {ortalama}");
            Console.ReadKey();
        }
    }
}
