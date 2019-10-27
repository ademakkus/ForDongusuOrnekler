using System;
using static System.Console;

namespace For_Dongusu_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rastgele;
          
            int ascii;
            int harfSayisi;
            Console.Write("Yazıacak harf sayısı giriniz ?:");
            harfSayisi = int.Parse(ReadLine());
            for (int i = 0; i < harfSayisi; i++)
            {
                rastgele = rnd.Next(65, 97);
                ascii = rastgele;
                char harf = Convert.ToChar(ascii);
                WriteLine(harf);
            }
            ReadKey();
        }
    }
}
