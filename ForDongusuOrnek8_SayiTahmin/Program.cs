using System;

namespace ForDongusuOrnek8_SayiTahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console penceresinin başlığını değiştirir
            Console.Title = "Sayı Tahmin Oyunu";
            //1 - 100 arasında rastgele bir sayıyı tahmin edelim

            int hak = 5;
            int rastgeleSayi;
            int tahmin;
            //Random : rastgele int türünde bir sayı üretir
            Random random = new Random();
            rastgeleSayi = random.Next(1, 100);
            for (; ; )
            {
                Console.Write("\nTahmininizi Giriniz : ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin==rastgeleSayi)
                {
                    Console.WriteLine("Tebrikler. Doğru tahmin ettiniz.");
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış Tahmin");
                    hak--;
                    if (hak==0)
                    {
                        Console.WriteLine("Hakkınız kalmadı\n");
                        break;
                    }
                    Console.WriteLine($"Kalan tahmin hakkınız : {hak}");
                }
            }
            Console.ReadKey();
        }
    }
}
