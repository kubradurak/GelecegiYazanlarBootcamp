using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    class Oyuncu
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Zar OyuncununZari { get; set; }

        public Bakiye OyuncununBakiyesi { get; set; }

        public int OyuncununBahisi { get; set; }

        public Oyuncu()
        {

        }

        public Oyuncu(string ad)
        {
            Ad = ad;
        }

        public void ZarAt()
        {
            // Oyuncu zarıyla zar atar 
            OyuncununZari.At();

        }

        public void BahisEkle()
        {
            OyuncununBakiyesi.BakiyeAzalir(OyuncununBahisi);

        }
    }
}
