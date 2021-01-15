using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    public class Bahis
    {

        public int ToplamBahis;

        // BAHİSLERİN TOPLAM DEĞERİNİ TUTMALIYIM 
        //

        public int toplamBahis
        {
            get
            {
                return ToplamBahis;
            }
            set
            {
                ToplamBahis = value;
            }
        }
    }
}
