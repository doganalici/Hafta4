using System;

namespace IfElseOrnek5_icice
{
    class Program
    {
        static void Main(string[] args)
        {
            //üç sayı içinden en büyük olanı bulalım
            int a, b, c, enbuyuk;

            Console.Write("a sayısını giriniz : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b sayısını giriniz : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c sayısını giriniz : ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                if (a>c)
                {
                    Console.WriteLine($"en büyük sayı : {a}");
                }
                else
                {
                    Console.WriteLine($"en büyük sayı : {c}");
                }
            }
            else if (b>a)
            {
                if (b>c)
                {
                    Console.WriteLine($"en büyük sayı : {b}");
                }
                else
                {
                    Console.WriteLine($"en büyük sayı : {c}");
                }
            }
           
            Console.ReadKey();
        }
    }
}
