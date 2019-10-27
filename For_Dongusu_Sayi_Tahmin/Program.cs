using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace For_Dongusu_Sayi_Tahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi =-1, rastgele;
            Random rnd = new Random();
            rastgele = rnd.Next(1, 100);

            do
            {
                Write("Enter the number between 1 and 100 :");
                sayi = int.Parse(ReadLine());
                if (sayi < 0 || sayi > 100)
                {

                    break;
                }
                else if(sayi<rastgele)
                {
                    ForegroundColor = Red;
                    Write("Büyük sayı giriniz\n");

                }
                else if(sayi>rastgele)
                {
                    ForegroundColor = DarkYellow;
                    Write("Küçük sayı giriniz\n");
                }
                else
                {

                    break;
                }
            } while (sayi != rastgele);
            Console.WriteLine("Tebrikler rastgele sayı :{0}",rastgele);
            //Write("rastgele sayı :{0}", rastgele);
            ReadKey();
        }
    }
}
