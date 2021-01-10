using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarMiYokMu
{
    class Program
    {
        static void Main(string[] args)
        {



            string[] sehirler = { "İstanbul", "Eskişehir", "Ankara", "Kutahya", "Adana", "İzmir" };
            Console.WriteLine("Bir şehir giriniz: ");
            string girilenSehir = Console.ReadLine();
            bool varMi = false;

            for (int i = 0; i < sehirler.Length; i++)
            {
                if (sehirler[i] == girilenSehir)
                {
                    Console.WriteLine($"Aradığın şehir {girilenSehir} bulundu ve indeksi {i}");
                    varMi = true;
                    break;  // bir kere buldu aramasına gerek yok.
                }

            }

            if (!varMi)
            {
                Console.WriteLine($"{girilenSehir} array'de yok");

            }

            Console.ReadLine();


        }
    }
}
