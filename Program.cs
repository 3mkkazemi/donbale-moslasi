using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)

        {
            //mohammad mahdi mohammad kazemi
            //تکلیف شماره6
            //پیشرفته1
            Console.WriteLine("number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int mmk = (i * (i + 1)) / 2;
                Console.WriteLine(mmk + "");

            }
            Console.WriteLine("ma mitavanim...");
            Console.ReadKey();
        }
    }
}
