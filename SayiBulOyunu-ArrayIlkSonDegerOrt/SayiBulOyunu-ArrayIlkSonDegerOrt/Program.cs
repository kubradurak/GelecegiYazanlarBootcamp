using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiBulOyunu_ArrayIlkSonDegerOrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================================");
            Console.WriteLine("| UYGULAMAMIZDA SAYI BULMA OYUNU VE DİZİ UYGULAMASI MEVCUTTUR. |");
            Console.WriteLine("| OYUN İÇİN : o                                                |");
            Console.WriteLine("| DİZİ UYGULAMASI İÇİN : d  BASMANIZ YETERLİDİR.               |");
            Console.WriteLine("|===============================================================");
            Console.WriteLine(" LÜTFEN SEÇİMİNİZİ YAPINIZ:");

            try
            {
                char diziOyunKarakteri = Convert.ToChar(Console.ReadLine());

                switch (diziOyunKarakteri)
                {
                    case 'd':
                    case 'D':
                        DiziUygulamasi();
                        break;
                    case 'o':
                    case 'O':
                        OyunUygulamasi();
                        break;

                    default:
                        Console.WriteLine("LÜTFEN D - O KARAKTERLERİNDEN BİRİNİ GİRİNİZ!");                     
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen Belirtilen değerde seçim yapınız!");
            }
            
            


            Console.ReadLine();

        }

        public static void DiziUygulamasi()
        {
           
            int[] sayilar = new int[17] { 54, 75, 85, 96, 74, 57, 74, 58, 485, 451, 123, 452, 68, 741, 2, 7 ,33};
            

            int min = sayilar[0];
            int max = sayilar[0];
            int sum = 0;
            double ort;

            for (int i = 0; i < sayilar.Length ; i++)
            {

                Console.Write(sayilar[i]);
                Console.Write("-");

                sum = sum + sayilar[i];
               
                if (min > sayilar[i])
                {
                    min = sayilar[i];
                }
                else if (max < sayilar[i])
                    max = sayilar[i];
            }

            ort = sum / sayilar.Length;

            Console.WriteLine("  ");
            Console.WriteLine($"----> En küçük değer: {min}");
            Console.WriteLine($"----> En büyük değer: {max}");
            Console.WriteLine($"----> Aritemetik ortalama: {ort}");

        }



        public static void OyunUygulamasi()
        {
            Console.WriteLine("SAYI BULMA OYUNUNA HOŞGELDİNİZ :)");

            bool OyunDevamEtsinMi = true;

            while (OyunDevamEtsinMi == true)
            {
                Random rastgeleSayiUretici = new Random();  // instance oluşturduk.
                int uretilenSayi = rastgeleSayiUretici.Next(0, 100);
                int kacinciTahmin = 0;
                bool sayiBulunduMu = false;


                Console.WriteLine("Tahminizi Giriniz:(0-100)");
                while (sayiBulunduMu == false)
                {
                 
                    int tahminEdilen = Convert.ToInt32(Console.ReadLine());

                    if (tahminEdilen > uretilenSayi)
                    {
                        Console.WriteLine("Aşağı in");
                        sayiBulunduMu = false;
                        kacinciTahmin++;
                    }
                    else if (tahminEdilen < uretilenSayi)
                    {
                        Console.WriteLine("Yukarı Çık");
                        sayiBulunduMu = false;
                        kacinciTahmin++;
                    }
                    else if (tahminEdilen == uretilenSayi)
                    {
                        Console.WriteLine("BİLDİN!!");
                        sayiBulunduMu = true;
                        kacinciTahmin++;
                    }
                }

                Console.WriteLine("*******");
                Console.WriteLine($"Doğru sayıyı {kacinciTahmin}. tahminde bildiniz");
                Console.WriteLine("Tekrar oynamak ister misiniz? (E/H)");
                char TekrarOynamakIcınKullaniciCevabi = Convert.ToChar(Console.ReadLine());
                switch (TekrarOynamakIcınKullaniciCevabi)
                {
                    case 'E':
                    case 'e':
                        OyunDevamEtsinMi = true;
                        break;
                    case 'H':
                    case 'h':
                        OyunDevamEtsinMi = false;
                        Console.WriteLine("BAAAAAYYYY");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("LÜTFEN E - H BASINIZ!");
                        break;
                }
            }

      



        }
    }
}
