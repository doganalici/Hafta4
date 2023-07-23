using System;

namespace NullOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {

            //?? ya da ??= şeklinde kullanılır
            //eğer değer yoksa null değerini alır
            //aksi durumda atanan değer ile işlem yapar

            string isim;
            Console.Write("İsminizi giriniz : ");
            isim = Console.ReadLine();
            string durum = isim ?? "İsim girilmedi";
            Console.WriteLine(durum);
            int? yas=null;
            yas = 12;
            Console.WriteLine(yas);
            int? a = null;
            int b = a??0;
            Console.WriteLine($"a={a} , b={b}");


            Console.ReadKey();
        }
    }
}
