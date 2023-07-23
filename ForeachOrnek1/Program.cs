using System;

namespace ForeachOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[] {"İstanbul", "Ankara", "İzmir", "Çorum", "Kırşehir" };
            Console.WriteLine("--- Diziyi For Döngüsü ile Yazdıralım ---\n");
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }

            Console.WriteLine("\n\n--- Diziyi For Döngüsü ile Yazdıralım ---\n");
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            Console.ReadKey();
        }
    }
}
