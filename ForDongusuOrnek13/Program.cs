using System;

namespace ForDongusuOrnek13
{
    class Program
    {
        static void Main(string[] args)
        {
            int yukseklik, genislik;
            int xKoord, yKoord;
            yukseklik = Console.WindowHeight;
            genislik = Console.WindowWidth;
            xKoord = genislik / 2;
            yKoord = yukseklik / 2;
            Console.Title = "İmleç Konumlandırma";
            Console.WriteLine($"Konsol penceresi yükseklik : {yukseklik}");
            Console.WriteLine($"Konsol penceresi genişlik : {genislik}");
            Console.WriteLine("Doğan ALICI");
            for (int i = 1; i < 10; i++)
            {
                Console.SetCursorPosition(xKoord, yKoord);
                Console.WriteLine("Doğan ALICI");
                xKoord++;
                yKoord++;

            }
            for (int i = 1; i < 10; i++)
            {
                Console.SetCursorPosition(xKoord, yKoord);
                Console.WriteLine("Doğan ALICI");
                xKoord--;
                yKoord++;

            }

            Console.ReadKey();
        }
    }
}
