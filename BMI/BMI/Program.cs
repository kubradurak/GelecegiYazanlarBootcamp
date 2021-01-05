using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        // EKSİKLER
        // KOŞULLARI KONTROL ET WEİGTH HEIGHT DEĞERLERİNİ KULLANICI HATALARI OLABİLİR
        // YANLIŞ TİPTE GİRİNDİĞİNDE DOĞRUSU GİRİLDİĞİNDE FORM KAPANIYOR.
        // BİR HESAPLAMA YAPTIKTAN SONRA TEKRAR YAPMAK İSTER Mİ SOR ?
        // KULLANICI AYNI EKRANDA İSTEDİĞİ KADAR HESAPLAMA YAPSIN TEK BİR TANE DEĞİL
        // TASARIMDA EKLEME YAP
        // GİTHUBA EKLE
        // 
       
        static void Main(string[] args)
        {

             int userWeight;
             int userHeight;
             double bmi;
            Console.WriteLine(" ====================");
            Console.WriteLine(" |  BMI Calculator  |");
            Console.WriteLine(" ====================");
            char next = 'y';

            while (next == 'y') {

            try
            {
            Console.WriteLine("Weight in kg: (ex: 60) ");
            userWeight = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Height in cm: (ex: 165)");
            userHeight = Convert.ToInt32(Console.ReadLine());
            bmi = userWeight / Math.Pow(userHeight / 100.0, 2);
            
            Status(bmi, next);

            }
                catch (FormatException)
            {
                Console.WriteLine("Please! Enter your height and weight in cm and kg");
                
            }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Your height and your weight cannot be 0! ");
                    
                }
                catch (Exception e)
            {
                Console.WriteLine("Error!", e.Message);
              
            }
           }
            Console.ReadLine();

        }

        private static void Status(double bmi, char next)
        {
            if (bmi <= 18.5)
            {
                Console.WriteLine($"Your bmi : {bmi}");
                Console.WriteLine(" ---------------");
                Console.WriteLine(" | UNDERWEİGHT |");
                Console.WriteLine(" ---------------");
            
            }
            else if (bmi > 18.5 & bmi <= 24.9)
            {
                Console.WriteLine($"Your bmi : {bmi}");
                Console.WriteLine(" -----------------");
                Console.WriteLine(" | NORMAL WEİGHT |");
                Console.WriteLine(" -----------------");

            }
            else if (bmi >= 25 & bmi <= 29.9)
            {
                Console.WriteLine($"Your bmi : {bmi}");
                Console.WriteLine(" --------------");
                Console.WriteLine(" | OVERWEIGHT |");
                Console.WriteLine(" --------------");
           
            }
            else if (bmi >= 30)
            {
                Console.WriteLine($"Your bmi : {bmi}");
                Console.WriteLine(" -----------");
                Console.WriteLine(" | OBESITY |");
                Console.WriteLine(" -----------");
              }

            Console.WriteLine("Would you like to do another calculation? (Y/N)");
            next = Convert.ToChar(Console.ReadLine());
            if (next != 'y')
            {
                Console.WriteLine("***");
                Environment.Exit(0);
            }
        }


    }

   
}
