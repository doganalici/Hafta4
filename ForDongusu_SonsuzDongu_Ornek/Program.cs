using System;

namespace ForDongusu_SonsuzDongu_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menü uygulaması
            //1 - Giriş
            //2 - Yeni Kayıt
            //3 - Kayıt Sil
            //4 - Kayıt Güncelle
            //5 - Çıkış
            string menu = @"
            Menü uygulaması

            1 - Giriş
            2 - Yeni Kayıt
            3 - Kayıt Sil
            4 - Kayıt Güncelle
            5 - Çıkış";
            string secenek;
            for (; ;)
            {
                Console.WriteLine(menu);
                Console.Write("\nMenü seçin. Çıkış için 5 tuşuna basın : ");
                secenek = Console.ReadLine();
                if (secenek=="5")
                {
                    Console.WriteLine("\nProgramdan çıkış yapılıyor.");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
