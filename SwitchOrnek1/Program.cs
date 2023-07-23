using System;

namespace SwitchOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            int gundegeri;
            string gun;
            Console.Write("Gün değerini giriniz (1-7 arası) : ");
            gundegeri = Convert.ToInt32(Console.ReadLine());

            #region if ile çözüm
            if (gundegeri == 0)
            {
                gun = "Pazartesi";
            }
            else if (gundegeri == 1)
            {
                gun = "Salı";
            }
            else if (gundegeri == 2)
            {
                gun = "Çarşamba";
            }
            else if (gundegeri == 3)
            {
                gun = "Perşembe";
            }
            else if (gundegeri == 4)
            {
                gun = "Cuma";
            }
            else if (gundegeri == 5)
            {
                gun = "Cumartesi";
            }
            else if (gundegeri == 6)
            {
                gun = "Pazar";
            }
            else
            {
                gun = "GEÇERSİZ";
            }
            Console.WriteLine($"\nGün değeri : {gundegeri} , Gün : {gun}");
            #endregion
            Console.WriteLine("\n------ Switch Case ile Çözüm ------\n");
            #region Switch case ile çözüm
            switch (gundegeri%7)
            {
                case 0:
                    gun = "PAZARTESİ";
                    break;
                case 1:
                    gun = "SALI";
                    break;
                case 2:
                    gun = "ÇARŞAMBA";
                    break;
                case 3:
                    gun = "PERŞEMBE";
                    break;
                case 4:
                    gun = "CUMA";
                    break;
                case 5:
                    gun = "CUMARTESİ";
                    break;
                case 6:
                    gun = "PAZAR";
                    break;
                default:
                    gun = "Gerersiz Gün";
                    break;
            }
            Console.WriteLine($"Gün değeri : {gundegeri} , Gün : {gun}");
            Console.WriteLine("\n*************************************");

            #endregion

            #region hafta sonu
            switch (gundegeri)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4: gun = "Hafta içi"; break;
                case 5:
                case 6: gun = "Hafta sonu"; break;
                default: gun = "Gerersiz Gün"; break;
            }
            Console.WriteLine($"\nGün değeri : {gundegeri} , Gün : {gun}");
            #endregion
            Console.ReadKey();
        }
    }
}
