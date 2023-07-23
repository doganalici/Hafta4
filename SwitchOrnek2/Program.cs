using System;

namespace SwitchOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ayDegeri;
            string ayIsmi, mevsim;
            Console.Write("Ay değerini giriniz (0 - 11) : ");
            ayDegeri = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----- AYIN İSMİ -----");
            switch (ayDegeri)
            {
                case 0: ayIsmi = "Ocak"; mevsim = "Kış"; break;
                case 1: ayIsmi = "Şubat"; mevsim = "Kış"; break;
                case 2: ayIsmi = "Mart"; mevsim = "İlkbahar"; break;
                case 3: ayIsmi = "Nisan"; mevsim = "İlkbahar"; break;
                case 4: ayIsmi = "Mayıs"; mevsim = "İlkbahar"; break;
                case 5: ayIsmi = "Haziran"; mevsim = "Yaz"; break;
                case 6: ayIsmi = "Temmuz"; mevsim = "Yaz"; break;
                case 7: ayIsmi = "Ağustos"; mevsim = "Yaz"; break;
                case 8: ayIsmi = "Eylül"; mevsim = "Sonbahar"; break;
                case 9: ayIsmi = "Ekim"; mevsim = "Sonbahar"; break;
                case 10: ayIsmi = "Kasım"; mevsim = "Sonbahar"; break;
                case 11: ayIsmi = "Aralık"; mevsim = "Kış"; break;
                default: ayIsmi = "GEÇERSİZ AY İSMİ"; mevsim = "GEÇERSİZ MEVSİM"; break;
            }
            //switch (ayDegeri)
            //{
            //    case 11:
            //    case 0:
            //    case 1: mevsim = "Kış"; break;
            //    case 2:
            //    case 3:
            //    case 4: mevsim = "İlkbahar"; break;
            //    case 5:
            //    case 6:
            //    case 7: mevsim = "Yaz"; break;
            //    case 8:
            //    case 9:
            //    case 10: mevsim = "Sonbahar"; break;
            //    default: mevsim = "GEÇERSİZ MEVSİM"; break;
            //}
            Console.WriteLine($"Değer : {ayDegeri} , Ay : {ayIsmi} , Mevsim : {mevsim}");
            Console.ReadKey();
        }
    }
}
