using System;

namespace SwitchOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            //öğrenci notu
            //0,1,2 Geçersiz
            //3 Orta
            //4 İyi
            //5 Pekiyi

            byte notu;
            string durum;
            Console.Write("Öğrenci notu (0 - 5 arası) : ");
            notu = Convert.ToByte(Console.ReadLine());
            switch (notu)
            {
                case 0:
                case 1:
                case 2: durum = "GEÇERSİZ"; break;
                case 3: durum = "ORTA"; break;
                case 4: durum = "İYİ"; break;
                case 5: durum = "PEKİYİ"; break;
                default: durum = "GEÇERSİZ NOT"; break;
            }
            Console.WriteLine($"Notu : {notu} , Durumu : {durum}");
            Console.ReadKey();
        }
    }
}
