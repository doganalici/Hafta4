using System;

namespace ForDongusuOrnek6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Alfabe Küçük Harfler ---");
            for (char harf = 'a'; harf <= 'z'; harf++)
            {
                Console.Write(harf);
                if (harf == 'z')
                {
                    break;
                }
                Console.Write(",");
            }

            Console.WriteLine("\n\n--- Alfabe Büyük Harfler ---");
            for (char harf = 'A'; harf <= 'Z'; harf++)
            {
                Console.Write(harf);
                if (harf == 'Z')
                {
                    break;
                }
                Console.Write(",");
            }


            Console.WriteLine("\n\n--- Alfabe Büyük Harfler Tersten ---");
            for (char harf = 'Z'; harf >= 'A'; harf--)
            {
                Console.Write(harf);
                if (harf == 'A')
                {
                    break;
                }
                Console.Write(",");
            }

            Console.WriteLine("\n\n--- Alfabe Küçük Harfler Tersten---");
            for (char harf = 'z'; harf >= 'a'; harf--)
            {
                Console.Write(harf);
                if (harf == 'a')
                {
                    break;
                }
                Console.Write(",");
            }

            Console.WriteLine("\n\n\n----- İki sayaç değişkeni kullanımı -----");
            Console.WriteLine("** Büyük küçük harf birlikte ----");
            //büyük harf için : by
            //küçük harf için : kc
            for (char by = 'A', kc = 'a'; by <= 'Z' && kc <= 'z'; by++, kc++)
            {
                Console.Write($" {by} {kc} --");
            }


            Console.WriteLine("\n\n--- Basit Çarpma Talosu ---");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{j} * {i} = {i*j}\t");
                    
                }
               
            }

            Console.ReadKey();
        }
    }
}
