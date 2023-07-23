using System;

namespace ForDongusuOrnek9_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console penceresinin başlığını değiştirir
            Console.Title = "Sayı Tahmin Oyunu";
            //1 - 128 arasında rastgele bir sayıyı tahmin edelim

            int hak = 7;
            int rastgeleSayi;
            int tahmin;
            //Random : rastgele int türünde bir sayı üretir
            Random random = new Random();
            rastgeleSayi = random.Next(1, 128);
            for (; ; )
            {
                Console.Write("\nTahmininizi Giriniz : ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin == rastgeleSayi)
                {
                    Console.WriteLine("Tebrikler. Doğru tahmin ettiniz.");
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış Tahmin");
                    hak--;
                    if (tahmin<rastgeleSayi)
                    {
                        Console.WriteLine("Daha büyük bir sayı tahmin ediniz");
                    }
                    else
                    {
                        Console.WriteLine("Daha küçük bir sayı tahmin ediniz");
                    }
                    
                    if (hak == 0)
                    {
                        Console.WriteLine($"Hakkınız kalmadı\nRastgele oluşan sayı : {rastgeleSayi}");
                        break;
                    }
                    Console.WriteLine($"Kalan tahmin hakkınız : {hak}");
                }
            }
            Console.ReadKey();
        }
    }
}
