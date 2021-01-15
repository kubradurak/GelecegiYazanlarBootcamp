using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    public class Bakiye
    {
        public int Tutar { get; set; }

        public Bakiye(int value)
        {
            Tutar = value;
        }
       
        public int BakiyeAzalir(int value)
        {
            if (Tutar > 0)
            {
                return Tutar = Tutar - value;
            }
            else
            {
                return 0 ;
            }
            

        }
        public int BakiyeArtar(int value)
        {
         return Tutar = Tutar + value;
           
        }

    }
}
