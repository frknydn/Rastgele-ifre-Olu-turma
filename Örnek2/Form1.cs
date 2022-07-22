using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool kucukHarfVarMi, buyukHarfVarMi, sayiVarMi, ozelKarakterVarMi;
        int sifreUzunlugu, sifreSayisi;
        Random rnd = new Random();

        private void btnUret_Click(object sender, EventArgs e)
        {
            rchSifreler.Text = "";
            kucukHarfVarMi = chkKucukHarf.Checked;
            buyukHarfVarMi = chkBuyukHarf.Checked;
            sayiVarMi = chkSayi.Checked;
            ozelKarakterVarMi = chkKarakter.Checked;

            sifreUzunlugu = (int)nupUzunlugu.Value;
            sifreSayisi = (int)nupSayisi.Value;

            string secilenKarakterler = "";

            KucukHarfEkle(ref secilenKarakterler);
            BuyukHarfEkle(ref secilenKarakterler);
            SayiEkle(ref secilenKarakterler);
            OzelKarakterEkle(ref secilenKarakterler);
            SifreUret(secilenKarakterler);
        }

        private void SifreUret(string secilenKarakterler)
        {
            for (int i = 0; i < sifreSayisi; i++)
            {
                string sifre = "";
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    sifre += secilenKarakterler[rnd.Next(secilenKarakterler.Length)];
                }
                rchSifreler.Text +=$"{i+1}. sifre:  " + sifre+"\n";
            }
        }

        private void OzelKarakterEkle(ref string secilenKarakterler)
        {
            if (ozelKarakterVarMi)
            {
                for (int i = 33; i < 48; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);

                }
                for (int i = 58; i < 65; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
        }

        private void SayiEkle(ref string secilenKarakterler)
        {
            if (sayiVarMi)
                for (int i = 48; i < 58; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
        }

        private void BuyukHarfEkle(ref string secilenKarakterler)
        {
            if (buyukHarfVarMi)
            {
                for (int i = 65; i < 91; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }

        }

        private void KucukHarfEkle(ref string secilenKarakterler)
        {
            if (kucukHarfVarMi) 
            {
                for (int i = 97; i < 123; i++)
                {
                    secilenKarakterler += Convert.ToChar(i);
                }
            }
        }
    }
}
