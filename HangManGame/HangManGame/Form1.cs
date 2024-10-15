using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        string secilenKelime;
        char[] secilenKelimeCharDizisi;
        string gizlenmisKelime = string.Empty;
        int konuNumarasi;
        int hak;
        int sayac;

        string image1 = Path.Combine(Application.StartupPath, "images", "1.png");

        string[] sehirler = {
            "ADANA", "ADIYAMAN", "AFYONKARAHİSAR", "AĞRI", "AMASYA", "ANKARA", "ANTALYA", "ARTVİN", "AYDIN",
            "BALIKESİR", "BİLECİK", "BİNGÖL", "BİTLİS", "BOLU", "BURDUR", "BURSA", "ÇANAKKALE", "ÇANKIRI",
            "ÇORUM", "DENİZLİ", "DİYARBAKIR", "EDİRNE", "ELAZIĞ", "ERZİNCAN", "ERZURUM", "ESKİŞEHİR",
            "GAZİANTEP", "GİRESUN", "GÜMÜŞHANE", "HAKKARİ", "HATAY", "IĞDIR", "ISPARTA", "İSTANBUL",
            "İZMİR", "KARS", "KASTAMONU", "KAYSERİ", "KIRIKKALE", "KIRKLARELİ", "KIRŞEHİR", "KİLİS",
            "KONYA", "KÜTAHYA", "MALATYA", "MANİSA", "MARDİN", "MERSİN", "MUĞLA", "MUŞ", "NEVŞEHİR",
            "NİĞDE", "ORDU", "OSMANİYE", "RİZE", "SAKARYA", "SAMSUN", "SİİRT", "SİNOP", "SİVAS",
            "TEKİRDAĞ", "TOKAT", "TRABZON", "TUNCELİ", "ŞANLIURFA", "UŞAK", "VAN", "YALOVA", "YOZGAT",
            "ZONGULDAK"
        };

        string[] yemekler = {
            "İSKENDER KEBAP", "LAHMACUN", "MANTI", "ADANA KEBAP", "BEYTİ", "KARNIYARIK",
            "HÜNKAR BEĞENDİ", "PİLAV", "DÖNER", "MENEMEN", "YAPRAK SARMA", "ÇİĞ KÖFTE",
            "PATLICAN MUSAKKA", "KUZU TANDIR", "İMAM BAYILDI", "TAVUK ŞİŞ", "ÇORBA", "FIRIN KEBABI",
            "ALİNAZİK", "MÜCVER", "KÖFTE", "GÖZLEME", "KUZU GÜVEÇ", "PİDE", "KURU FASULYE",
            "BULGUR PİLAVI", "MIHLAMA", "TESTİ KEBABI", "ETLİ EKMEK", "CACIK"
        };

        string[] tatlilar = {
            "BAKLAVA", "KÜNEFE", "REVANİ", "AŞURE", "SÜTLAÇ",
            "KAZANDİBİ", "GÜLLAÇ", "ŞEKERPARE", "TULUMBA", "İRMİK HELVASI",
            "KADAYIF", "LOKMA", "KEŞKÜL", "TAVUKGÖĞSÜ", "FIRIN SÜTLAÇ",
            "HÖŞMERİM", "EKMEK KADAYIFI", "UN HELVASI", "SUPANGLE",
            "ZERDE", "KEMALPAŞA", "TRİLEÇE", "DONDURMA",
            "AYVA TATLISI", "KABAK TATLISI", "HANIMGÖBEĞİ",
            "ORCİK", "PESTİL", "SAMSATATLI", "TEL KADAYIF"
        };



        public Form1()
        {
            InitializeComponent();
            string kapakFotosu = Path.Combine(Application.StartupPath, "images", "kapak_foto.png");
            pictureBox.Image = Image.FromFile(kapakFotosu);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblIpucu.Visible = true;
            lblHak.Visible = true;
            lblHarfGiriniz.Visible = true;
            btnKontrol.Visible = true;
            txtGirilenHarf.Visible = true;
            lblTamTahmin.Visible = true;
            txtTamTahmin.Visible = true;
            btnTamKontrol.Visible = true;
            this.BackColor = Color.White;
            hak = 7;
            gizlenmisKelime = "";
            txtGirilenHarf.Text = "";
            txtTamTahmin.Text = "";
            konuNumarasi = random.Next(1, 4);
            switch (konuNumarasi)
            {
                case 1:
                    secilenKelime = sehirler[random.Next(0, 81)];
                    lblIpucu.Text = "İpucu: Bir şehir!";
                    break;
                case 2:
                    secilenKelime = yemekler[random.Next(0, 30)];
                    lblIpucu.Text = "İpucu: Bir yemek!";
                    break;
                case 3:
                    secilenKelime = tatlilar[random.Next(0, 30)];
                    lblIpucu.Text = "İpucu: Bir tatlı!";
                    break;
            }
            lblHak.Text = "Kalan Hak: " + hak;
            pictureBox.Image = Image.FromFile(image1);
            secilenKelimeCharDizisi = secilenKelime.ToCharArray();
            sayac = secilenKelime.Length;
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                if (secilenKelime[i] == ' ')
                    sayac--;
            }

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                if (secilenKelime[i] != ' ')
                {
                    secilenKelimeCharDizisi[i] = '⊡';
                }
            }
            lblKelime.Text = string.Concat(secilenKelimeCharDizisi);
        }

        private void bntKontrol_Click(object sender, EventArgs e)
        {
            if (hak > 0 && !(string.IsNullOrEmpty(txtGirilenHarf.Text)))
            {
                char girilenHarf = txtGirilenHarf.Text[0];
                bool harfBulundu = false;
                txtGirilenHarf.Text = "";
                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (secilenKelime[i] == char.ToUpper(girilenHarf))
                    {
                        secilenKelimeCharDizisi[i] = char.ToUpper(Convert.ToChar(girilenHarf));
                        lblKelime.Text = string.Concat(secilenKelimeCharDizisi);
                        harfBulundu = true;
                        sayac--;
                        if (sayac == 0)
                        {
                            this.BackColor = Color.Green;
                            MessageBox.Show("Tebrikler Kazandınız !");
                            btnBaslat.PerformClick();
                            break;
                        }
                    }
                }

                if ((!harfBulundu) && sayac != 0)
                {
                    hak--;
                    lblHak.Text = "Kalan Hak: " + hak;
                    int fotoNumarasi = 8 - hak;
                    string fotoAdiOlusan = fotoNumarasi + ".png";
                    string image = Path.Combine(Application.StartupPath, "images", fotoAdiOlusan);
                    pictureBox.Image = Image.FromFile(image);
                    if (hak == 0)
                    {
                        this.BackColor = Color.Red;
                        MessageBox.Show("Oyunu Kaybettiniz ! Doğru cevap: " + secilenKelime);
                        btnBaslat.PerformClick();
                    }
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTamKontrol_Click(object sender, EventArgs e)
        {

            if (txtTamTahmin.Text.ToUpper().Equals(secilenKelime))
            {
                kazanmaAnimasyonu();
            }
            else
            {
                MessageBox.Show("Yanlış tahmin !");
            }
        }

        private void kazanmaAnimasyonu()
        {
            lblKelime.Text = secilenKelime;
            this.BackColor = Color.Green;
            MessageBox.Show("Tebrikler Kazandınız !");
            btnBaslat.PerformClick();
        }
    }
}
