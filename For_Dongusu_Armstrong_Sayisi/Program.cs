using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace For_Dongusu_Armstrong_Sayisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, toplam = 0, gecici, kalan;
            Write("Enter the number :");
            sayi = int.Parse(ReadLine());
            gecici = sayi;
            while (sayi > 0)
            {
                kalan = sayi % 10;
                toplam += kalan * kalan * kalan;
                sayi /= 10;

            }
            if (gecici==toplam)
            {
                ForegroundColor = Red;
                WriteLine("{0} sayısı armstrong sayısıdır",gecici);
            }
            else
            {
                ForegroundColor = Green;
                WriteLine("{0} sayısı armstrong degildir",gecici);
            }
            ReadKey();

        }
    }
}
