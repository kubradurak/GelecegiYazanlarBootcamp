using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool asalMi = false;
            
            for (int i = 2; i <= 10000; i++)
            {
                for (int j = 2; j <= 10000; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        asalMi = false;
                        break;
                    }

                }
                if (asalMi)
                {
                    Console.WriteLine($"{i} sayısı asaldır.");
                }
                asalMi = true;
            }



            Console.ReadLine();
        }
    }
}
