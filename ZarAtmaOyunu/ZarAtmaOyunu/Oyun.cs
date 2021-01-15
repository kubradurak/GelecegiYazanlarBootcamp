using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    class Oyun
    {
        public Oyuncu BirinciOyuncu { get; set; }
        public Oyuncu İkinciOyuncu { get; set; }
      

        // OYUNDA YAPILACAKLAR 

        public void IlkOyuncuZarAt()
        {
            BirinciOyuncu.ZarAt();

        }
        public void İkinciOyuncuZarAt()
        {
            İkinciOyuncu.ZarAt();

        }

       

        public Oyuncu Karsılastır()
        {
            if (BirinciOyuncu.OyuncununZari.Deger > İkinciOyuncu.OyuncununZari.Deger)
            {
                               
                return BirinciOyuncu;

            }else if(BirinciOyuncu.OyuncununZari.Deger < İkinciOyuncu.OyuncununZari.Deger)
            {
                
                return İkinciOyuncu;

            }else
            {
                return null;
            }

          

        }

    }
}
