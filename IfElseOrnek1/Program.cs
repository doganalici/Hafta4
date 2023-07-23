using System;

namespace IfElseOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı tarafından girilen
            //iki sayıdan büyük olanı bulalım

            int s1, s2;
            Console.Write("Birinci sayıyı giriniz : ");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz : ");
            s2 = Convert.ToInt32(Console.ReadLine());

            if (s1>s2)
            {
                Console.WriteLine($"{s1} > {s2}");
            }
            else if (s1==s2)
            {
                Console.WriteLine($"{s1} = {s2}");
            }
            else
            {
                Console.WriteLine($"{s2} > {s1}");
            }
        }
    }
}
