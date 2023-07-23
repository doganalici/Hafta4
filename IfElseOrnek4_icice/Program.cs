using System;

namespace IfElseOrnek4_icice
{
    class Program
    {
        static void Main(string[] args)
        {
            int notu;
            string harfNotu;
            Console.Write("Öğrenci notunu giriniz : ");
            notu = Convert.ToInt32(Console.ReadLine());
            if (notu < 0 || notu > 100)
            {
                Console.WriteLine("Geçersiz not girişi.");
            }
            else
            {
                if (notu <= 100 && notu >= 80)
                {
                    harfNotu = "AA";
                }
                else if (notu < 80 && notu >= 70)
                {
                    harfNotu = "BB";
                }
                else if (notu < 70 && notu >= 60)
                {
                    harfNotu = "CC";
                }
                else if (notu < 60 && notu >= 40)
                {
                    harfNotu = "DD";
                }
                else
                {
                    harfNotu = "FF";
                }
                Console.WriteLine($"Harf Notu : {harfNotu}");

            }

            Console.ReadKey();
        }
    }
}
