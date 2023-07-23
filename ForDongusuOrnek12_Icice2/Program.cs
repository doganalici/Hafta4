using System;

namespace ForDongusuOrnek12_Icice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Kare Şeklinde Oluşturma ---\n");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n--- Üçgen Şeklinde Oluşturma ---\n");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                    
                }
                Console.WriteLine();
            }

             Console.WriteLine("\n\n--- Ters Üçgen Şeklinde Oluşturma ---\n");
            for (int i = 10; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                    
                }
                Console.WriteLine();
            }

             Console.WriteLine("\n\n--- Ters Üçgen Şeklinde Oluşturma ---\n");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 10; j >= i; j--)
                {
                    Console.Write(j + " ");
                    
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
