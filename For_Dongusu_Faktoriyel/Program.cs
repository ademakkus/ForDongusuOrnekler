using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace For_Dongusu_Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            int faktoriyel=1;
            int sayi;
            
            Write("Faktöriyeli alınacak sayıyı giriniz :");
            sayi = int.Parse(ReadLine());
            for (int i = 1; i <=sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            ForegroundColor = ConsoleColor.Green;
            WriteLine("{0} sayısının faktöriyeli :{1}", sayi, faktoriyel);
            ReadKey();
        }
    }
}
