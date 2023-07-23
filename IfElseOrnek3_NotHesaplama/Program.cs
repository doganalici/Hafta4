using System;

namespace IfElseOrnek3_NotHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            //öğrencinin vize,final,proje notları
            //vize %35, final %40, proje %25
            //geçme notu : 60
            double vize, final, proje, ortalama;

            Console.Write("Vize notunu giriniz : ");
            vize = Convert.ToDouble(Console.ReadLine());

            Console.Write("Final notunu giriniz : ");
            final = Convert.ToDouble(Console.ReadLine());

            Console.Write("Proje notunu giriniz : ");
            proje = Convert.ToDouble(Console.ReadLine());

            ortalama = vize * 0.35 + final * 0.4 + proje * 0.25;

            //if (ortalama>=60)
            //{
            //    Console.WriteLine($"Tebrikler. Not ortalaması : {ortalama}");
            //}
            //else
            //{
            //    Console.WriteLine($"Kaldınız. Not ortalaması : {ortalama}");
            //}

            #region 1. yol
            //if (ortalama <= 100 && ortalama >= 80)
            //{
            //    Console.WriteLine("AA");
            //}
            //else if (ortalama < 80 && ortalama >= 70)
            //{
            //    Console.WriteLine("BB");
            //}
            //else if (ortalama < 70 && ortalama >= 60)
            //{
            //    Console.WriteLine("CC");
            //}
            //else if (ortalama < 60 && ortalama >= 40)
            //{
            //    Console.WriteLine("DD");
            //}
            //else
            //{
            //    Console.WriteLine("FF");
            //}

            #endregion
            #region 2. yol
            string harfNotu;
            if (ortalama <= 100 && ortalama >= 80)
            {
                harfNotu = "AA";
            }
            else if (ortalama < 80 && ortalama >= 70)
            {
                harfNotu = "BB";
            }
            else if (ortalama < 70 && ortalama >= 60)
            {
                harfNotu = "CC";
            }
            else if (ortalama < 60 && ortalama >= 40)
            {
                harfNotu = "DD";
            }
            else if (ortalama < 40 && ortalama >= 0)
            {
                harfNotu = "FF";
            }
            else
            {
                harfNotu = "HATALI";
            }
            Console.WriteLine($"Öğrenci harf notu : {harfNotu}");
            #endregion


            Console.ReadKey();
        }
    }
}
