using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * 
             * Bu oyunda iki oyuncu vardır. [oyun diye nesne var. Oyuncu diye nesne var]
             * Her oyuncunun bir zarı vardır. [zar diye nesne var]
             * Her oyuncunun bakiyesi vardır. [bakiye diye nesne var]
             * Her oyuncu zar öncesi bahis girer. [bahis nesne. bahis girmek eylem. Metot var]
             * BAHİS ŞARTI ! Bir taraf 5 lira girerse diğer tarafta en az 5 lira girebilir.(9
             * Oyuncular zar atar. [eylem var. Metot var] 
             * Zarlar karşılaştırılır. [Metot]
             * Büyük atan kazanır. [Metot]
             * Kazanan bahisleri alır. [Metot]
             * 
             * Tekrar oynamak isterlerse bir tarafın bakiyesi bitesiye kadar yani iflas edesiye kadar oynama hakkı vardır.
             * 
             * 
             * 
             * 
             * Nesneler:
             *  - Oyun 
             *  - Oyuncu
             *  - Zar
             *  - Bahis
             *  
             * 
             * 
             * 
             * */


        }
        Oyun zarOyunu = new Oyun(); // oyun nesnemizi oluşturduk.

        private void btn_oyuncuBir_Click(object sender, EventArgs e)
        {
            zarOyunu.IlkOyuncuZarAt();
            lb_birinciZar.Text = zarOyunu.BirinciOyuncu.OyuncununZari.Deger.ToString();
            btn_oyuncuİki.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
                zarOyunu.İkinciOyuncuZarAt();
                lb_ikinciZar.Text = zarOyunu.İkinciOyuncu.OyuncununZari.Deger.ToString();

                Oyuncu kazananOyuncu = zarOyunu.Karsılastır();

                if (kazananOyuncu != null)
                {
                    lb_kazanan.Text = $"{kazananOyuncu.Ad} , {kazananOyuncu.OyuncununZari.Deger} ile kazandı.";

                    if (kazananOyuncu.Ad == lb_oyuncuBir.Text)
                    {
                        zarOyunu.BirinciOyuncu.OyuncununBakiyesi.BakiyeArtar(Convert.ToInt32(label1.Text));
                        lb_birinciOyuncu_toplamBakiye.Text = zarOyunu.BirinciOyuncu.OyuncununBakiyesi.Tutar.ToString();
                    }
                    else if (kazananOyuncu.Ad == lb_oyuncuİki.Text)
                    {
                        zarOyunu.İkinciOyuncu.OyuncununBakiyesi.BakiyeArtar(Convert.ToInt32(label1.Text));
                        lb_ikinciOyuncu_toplamBakiye.Text = zarOyunu.İkinciOyuncu.OyuncununBakiyesi.Tutar.ToString();
                    }

                }
                else
                {
                    lb_kazanan.Text = "Berabere Kazanan Yok";
                    MessageBox.Show("Beraberlik durumunda tekrar zar atılır. Bahisler değiştirilmez. Lütfen zar atınız!");
                }


            if (zarOyunu.BirinciOyuncu.OyuncununBakiyesi.Tutar == 0)
            {
               MessageBox.Show($"{zarOyunu.BirinciOyuncu.Ad} iflas etti.");
                btn_bahisEkle_birinciOyuncu.Enabled = false;
                
           }
            else if (zarOyunu.İkinciOyuncu.OyuncununBakiyesi.Tutar == 0)
            {
                MessageBox.Show($" {zarOyunu.İkinciOyuncu.Ad} iflas etti.");
                btn_bahisEkle_ikinciOyuncu.Enabled = false;
            }

        }

        private void btn_ekle_birinciOyuncu_Click(object sender, EventArgs e)
        {
                       
            string oyuncuBirAd = txt_oyuncuBir.Text;         
            
            zarOyunu.BirinciOyuncu = new Oyuncu(oyuncuBirAd); // oyuncumuzu oluşturmalısın
            zarOyunu.BirinciOyuncu.OyuncununZari = new Zar(); // oyuncunun zarını oluşturmalıyız.

            zarOyunu.BirinciOyuncu.Ad = oyuncuBirAd;
            lb_oyuncuBir.Text = zarOyunu.BirinciOyuncu.Ad;
            btn_ekle_ikinciOyuncu.Enabled = true;

        }

        private void btn_ekle_ikinciOyuncu_Click(object sender, EventArgs e)
        {
            string oyuncuİkiAd = txt_oyuncuIki.Text;
            zarOyunu.İkinciOyuncu = new Oyuncu(oyuncuİkiAd);
            zarOyunu.İkinciOyuncu.OyuncununZari = new Zar();
            btn_bahisEkle_birinciOyuncu.Enabled = true;
            zarOyunu.İkinciOyuncu.Ad = oyuncuİkiAd;
            lb_oyuncuİki.Text = zarOyunu.İkinciOyuncu.Ad;



        }

        public void btn_bahisEkle_birinciOyuncu_Click(object sender, EventArgs e)
        {       


            int birinciOyuncuToplamBakiye = Convert.ToInt32(lb_birinciOyuncu_toplamBakiye.Text);
            int birinciOyuncuBahis = Convert.ToInt32(txt_bahisEkle_birinciOyuncu.Text);

            if (birinciOyuncuBahis > birinciOyuncuToplamBakiye)
            {
                MessageBox.Show("Lütfen bakiyenizden fazla bahis girmeyiniz!");
                txt_bahisEkle_birinciOyuncu.Text = "";

            }
            else
            {
                lb_bahis_birinciOyuncu.Text = birinciOyuncuBahis.ToString();
                btn_bahisEkle_ikinciOyuncu.Enabled = true;
                zarOyunu.BirinciOyuncu.OyuncununBakiyesi = new Bakiye(birinciOyuncuToplamBakiye);
                zarOyunu.BirinciOyuncu.OyuncununBakiyesi.BakiyeAzalir(birinciOyuncuBahis);
                lb_birinciOyuncu_toplamBakiye.Text = zarOyunu.BirinciOyuncu.OyuncununBakiyesi.Tutar.ToString();
            }

        }

        public void btn_bahisEkle_ikinciOyuncu_Click(object sender, EventArgs e)
        {
            int ikinciOyuncuToplamBakiye = Convert.ToInt32(lb_ikinciOyuncu_toplamBakiye.Text);
            int ikinciOyuncuBahis = Convert.ToInt32(txt_bahisEkle_ikinciOyuncu.Text);
            lb_bahis_ikinciOyuncu.Text = ikinciOyuncuBahis.ToString();
            btn_oyuncuBir.Enabled = true;

            if (ikinciOyuncuBahis > ikinciOyuncuToplamBakiye)
            {
                MessageBox.Show("Lütfen bakiyenizden fazla bahis girmeyiniz!");
                txt_bahisEkle_ikinciOyuncu.Text = "";
            }
            else
            {
                zarOyunu.İkinciOyuncu.OyuncununBakiyesi = new Bakiye(ikinciOyuncuToplamBakiye);
                zarOyunu.İkinciOyuncu.OyuncununBakiyesi.BakiyeAzalir(ikinciOyuncuBahis);
                lb_ikinciOyuncu_toplamBakiye.Text = zarOyunu.İkinciOyuncu.OyuncununBakiyesi.Tutar.ToString();


                int toplamBahis = Convert.ToInt32(lb_bahis_birinciOyuncu.Text) + Convert.ToInt32(lb_bahis_ikinciOyuncu.Text);

                label1.Text = toplamBahis.ToString();

                Bahis bahis = new Bahis();
                bahis.toplamBahis = toplamBahis;
            }

            


        }

    }
}
