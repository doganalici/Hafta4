using System;

namespace ForDongusuOrnek5_Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, faktoriyel = 1;
            Console.Write("Sayı giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi < 0)
            {
                Console.WriteLine("Negatif sayıların faktoriyeli yoktur");
            }
            else
            {
                for (int i = 1; i <= sayi; i++)
                {
                    faktoriyel *= i;
                    Console.WriteLine($"{sayi}! = {faktoriyel}");
                    
                }
                
            }


            Console.ReadKey();
        }
    }
}
