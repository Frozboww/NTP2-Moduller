using System;
using System.Drawing;
using System.Windows.Forms;

namespace modul3_3
{
    // Kalýtýmý (Form) doðrudan C# nesne modeli üzerinden devralýyoruz
    public partial class Form1 : Form
    {
        // Tasarým bileþenlerini kod seviyesinde tanýmlýyoruz
        private Label lblSayi1;
        private Label lblSayi2;
        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Button btnHesapla;
        private Label lblSonuc;

        public Form1()
        {
            // HATA ÇÖZÜMÜ: Çakýþma üreten arka plan InitializeComponent çaðrýsýný kaldýrýp
            // form özelliklerini doðrudan kod ile ayaða kaldýrýyoruz.
            this.Text = "While Döngüsü Ýle Sayýlarý Toplama (modul3_3)";
            this.Width = 400;
            this.Height = 280;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Dinamik tasarýmý oluþturan metodumuzu çaðýrýyoruz
            TasarimiOlustur();
        }

        // Tümüyle C# koduyla arayüz bileþenlerinin konumlandýrýlmasý ve çizilmesi
        private void TasarimiOlustur()
        {
            // 1. Sayý Bilgilendirme Etiketi
            lblSayi1 = new Label();
            lblSayi1.Text = "Baþlangýç Sayýsý:";
            lblSayi1.Location = new Point(30, 35);
            lblSayi1.AutoSize = true;
            lblSayi1.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(lblSayi1);

            // 1. Sayý Giriþ Kutusu
            txtSayi1 = new TextBox();
            txtSayi1.Location = new Point(160, 32);
            txtSayi1.Width = 100;
            txtSayi1.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(txtSayi1);

            // 2. Sayý Bilgilendirme Etiketi
            lblSayi2 = new Label();
            lblSayi2.Text = "Bitiþ Sayýsý:";
            lblSayi2.Location = new Point(30, 75);
            lblSayi2.AutoSize = true;
            lblSayi2.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(lblSayi2);

            // 2. Sayý Giriþ Kutusu
            txtSayi2 = new TextBox();
            txtSayi2.Location = new Point(160, 72);
            txtSayi2.Width = 100;
            txtSayi2.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(txtSayi2);

            // Hesaplama Butonu
            btnHesapla = new Button();
            btnHesapla.Text = "While Döngüsü Ýle Topla";
            btnHesapla.Location = new Point(30, 120);
            btnHesapla.Width = 230;
            btnHesapla.Height = 35;
            btnHesapla.Font = new Font("Arial", 10, FontStyle.Bold);

            // Butonun týklama olayýný dinamik koda baðlýyoruz (1 Baþvuru saðlanýyor)
            btnHesapla.Click += new EventHandler(btnHesapla_Click);
            this.Controls.Add(btnHesapla);

            // Sonuç Gösterim Etiketi
            lblSonuc = new Label();
            lblSonuc.Text = "Toplam Sonucu: 0";
            lblSonuc.Location = new Point(30, 180);
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Arial", 12, FontStyle.Bold);
            lblSonuc.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblSonuc);
        }

        // Butona týklandýðýnda çalýþacak olan 'while' döngüsü toplama mantýðý
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Kutularýn boþ olup olmadýðýný denetliyoruz
            if (string.IsNullOrEmpty(txtSayi1.Text) || string.IsNullOrEmpty(txtSayi2.Text))
            {
                MessageBox.Show("Lütfen her iki sayý alanýný da doldurunuz!", "Eksik Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Büyük harfle .Text özellikleri kullanýlarak string veriler tamsayýya dönüþtürülüyor
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            int baslangic, bitis;
            int toplam = 0;

            // Yön tespiti (Kullanýcý önce büyük veya küçük sayý girmiþ olabilir)
            if (sayi1 <= sayi2)
            {
                baslangic = sayi1;
                bitis = sayi2;
            }
            else
            {
                baslangic = sayi2;
                bitis = sayi1;
            }

            // Sýnav dökümanýnda istenen asýl WHILE döngüsü yapýsý
            int i = baslangic;
            while (i <= bitis)
            {
                toplam = toplam + i;
                i++;
            }

            // Elde edilen ardýþýk toplamý ekrandaki etikete yazdýrýyoruz
            lblSonuc.Text = string.Format("Toplam Sonucu: {0}", toplam);
        }
    }
}