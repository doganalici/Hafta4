using System;
using System.Collections;
using System.Collections.Generic;

namespace ForeachOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //koleksiyon tanımlama
            List<string> isimler = new List<string>();
            //koleksiyona eleman ekleme
            isimler.Add("Adem");
            isimler.Add("Doğan");
            isimler.Add("Umut");
            isimler.Add("Mehmet");
            isimler.Add("Zehra");
            isimler.Add("Veciye");
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("\n-----------------\n");
            ArrayList liste = new ArrayList();
            liste.Add("Can");
            liste.Add("Canan");
            liste.Add(1000);
            liste.Add(12.33);
            liste.Add(true);
            liste.Add('K');
            foreach (var eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            Console.ReadKey();
        }
    }
}
