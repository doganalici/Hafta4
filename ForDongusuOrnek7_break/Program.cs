using System;

namespace ForDongusuOrnek7_break
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı tarafından kullanıcı adı ve 
            //şifre doğru girilene kadar 
            //tekrar tekrar giriş denemesi yapılsın
            string kadi, sifre;
            string uname = "user";
            string pass = "1234";

            for (; ; )
            {
                Console.Write("Kullanıcı adını giriniz : ");
                kadi = Console.ReadLine();
                Console.Write("Şifrenizi giriniz : ");
                sifre = Console.ReadLine();
                if (kadi==uname && sifre==pass)
                {
                    Console.WriteLine("\nTebrikler. Giriş yapabilirsiniz.");
                    break;
                }
                else
                {
                    Console.WriteLine("\nYanlış kullanıcı adı veya şifre\n\n");
                }

            }
            Console.ReadKey();
        }
    }
}
