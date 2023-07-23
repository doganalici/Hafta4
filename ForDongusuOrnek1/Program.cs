using System;

namespace ForDongusuOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- DÖNGÜ KULLANMADAN -------\n");
            Console.WriteLine("C# Döngüler konusuna hoş geldiniz.");
            Console.WriteLine("C# Döngüler konusuna hoş geldiniz.");
            Console.WriteLine("C# Döngüler konusuna hoş geldiniz.");
            Console.WriteLine("C# Döngüler konusuna hoş geldiniz.");
            Console.WriteLine("C# Döngüler konusuna hoş geldiniz.");
            Console.WriteLine("C# Döngüler konusuna hoş geldiniz.");
            Console.WriteLine("C# Döngüler konusuna hoş geldiniz.");
            Console.WriteLine("C# Döngüler konusuna hoş geldiniz.");
            Console.WriteLine("C# Döngüler konusuna hoş geldiniz.");
            Console.WriteLine("C# Döngüler konusuna hoş geldiniz.");

            Console.WriteLine("\n\n----- FOR DÖNGÜSU KULLANARAK -----\n");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
