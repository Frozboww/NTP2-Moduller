using System;
using System.Drawing;
using System.Windows.Forms;

namespace modul3_4
{
    public partial class Form1 : Form
    {
        // Tasarým bileþenlerini kod seviyesinde tanýmlýyoruz
        private Label lblBaslik;
        private Label lblSayi;
        private TextBox txtSayi;
        private Button btnHesapla;
        private Label lblSonuc;
        private Label lblHataMesaji;

        public Form1()
        {
            // Windows Forms'un temel tasarým yükleyicisini çaðýrýyoruz
            InitializeComponent();

            // Pencere (Form) genel görsel ayarlarýný kodla yapýyoruz
            this.Text = "Faktöriyel Alma Programý (modul3_4)";
            this.Width = 450;
            this.Height = 320;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Dinamik tasarým metodumuzu tetikliyoruz
            TasarimiOlustur();

            // Dinamik olarak oluþturduðumuz butonun týklama olayýný baðlýyoruz
            btnHesapla.Click += new EventHandler(btnHesapla_Click);
        }

        // C# koduyla arayüz bileþenlerinin konumlandýrýlmasý ve formun çizilmesi
        private void TasarimiOlustur()
        {
            // Baþlýk Etiketi
            lblBaslik = new Label();
            lblBaslik.Text = "FAKTÖRÝYEL ALMA PROGRAMI";
            lblBaslik.Location = new Point(30, 20);
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Arial", 12, FontStyle.Bold);
            lblBaslik.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblBaslik);

            // Sayý Bilgilendirme Etiketi
            lblSayi = new Label();
            lblSayi.Text = "Sayý Giriniz:";
            lblSayi.Location = new Point(30, 75);
            lblSayi.AutoSize = true;
            lblSayi.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(lblSayi);

            // Giriþ Metin Kutusu (TextBox)
            txtSayi = new TextBox();
            txtSayi.Location = new Point(130, 72);
            txtSayi.Width = 120;
            txtSayi.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(txtSayi);

            // Hesaplama Butonu
            btnHesapla = new Button();
            btnHesapla.Text = "Hesapla";
            btnHesapla.Location = new Point(270, 70);
            btnHesapla.Width = 100;
            btnHesapla.Height = 26;
            btnHesapla.Font = new Font("Arial", 9, FontStyle.Bold);
            this.Controls.Add(btnHesapla);

            // Sonuç Gösterim Etiketi
            lblSonuc = new Label();
            lblSonuc.Text = "Sonuç: 1";
            lblSonuc.Location = new Point(30, 130);
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Arial", 11, FontStyle.Bold);
            lblSonuc.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblSonuc);

            // Dinamik Hata Bildirim Etiketi (Kullanýcýya özel mesajlar için)
            lblHataMesaji = new Label();
            lblHataMesaji.Text = "";
            lblHataMesaji.Location = new Point(30, 180);
            lblHataMesaji.Width = 380;
            lblHataMesaji.Height = 80;
            lblHataMesaji.Font = new Font("Arial", 9, FontStyle.Italic);
            lblHataMesaji.ForeColor = Color.DarkRed;
            this.Controls.Add(lblHataMesaji);
        }

        // Butona týklandýðýnda çalýþacak dökümana tam uyumlu fonksiyon
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Her yeni hesaplamada hata etiketini temizliyoruz
            lblHataMesaji.Text = "";

            try
            {
                // YÖNERGE ADIMI: TextBox kontrolünün boþ býrakýlmasýna karþý hata fýrlatma
                if (string.IsNullOrEmpty(txtSayi.Text.Trim()))
                {
                    throw new ArgumentNullException();
                }

                // YÖNERGE ADIMI: Karakter girilmesine karþý dönüþtürme (FormatException tetikler)
                int sayi = Convert.ToInt32(txtSayi.Text);

                // YÖNERGE ADIMI: Girilen sayýnýn negatif olmasýna karþý throw ile özel durum oluþturma
                if (sayi < 0)
                {
                    throw new Exception("Hata! Faktöriyeli alýnacak sayý pozitif olmalýdýr.");
                }

                // YÖNERGE ADIMI: Aritmetiksel iþlemleri sayý taþmalarýna karþý denetimli (checked) hale getirme
                long faktoriyel = 1;
                checked
                {
                    for (int i = 1; i <= sayi; i++)
                    {
                        faktoriyel = faktoriyel * i;
                    }
                }

                // Hesaplama baþarýlý ise sonucu ekrana yazdýrýyoruz
                lblSonuc.Text = string.Format("Sonuç: {0}", faktoriyel);
            }
            // YÖNERGE ADIMI: Ýki adet catch ifadesinde özel durumlarý yakalama
            catch (ArgumentNullException)
            {
                lblHataMesaji.Text = "Hata! Sayý alaný boþ býrakýlamaz. Lütfen bir deðer giriniz.";
                lblSonuc.Text = "Sonuç: Hata";
            }
            catch (FormatException)
            {
                lblHataMesaji.Text = "Hata! Geçersiz karakter girdiniz. Lütfen sadece tam sayý giriniz.";
                lblSonuc.Text = "Sonuç: Hata";
            }
            catch (OverflowException)
            {
                lblHataMesaji.Text = "Hata! Çok büyük bir sayý girdiniz, veri türü sýnýrlarý aþýldý (Sayý Taþmasý).";
                lblSonuc.Text = "Sonuç: Hata";
            }
            catch (Exception ex)
            {
                // Negatif sayý durumu için fýrlattýðýmýz özel mesajý yakalýyoruz
                lblHataMesaji.Text = ex.Message;
                lblSonuc.Text = "Sonuç: Hata";
            }
            // YÖNERGE ADIMI: Ýþlem bittikten sonra textbox'ý temizleyip imleci konumlandýrma
            finally
            {
                txtSayi.Text = "";
                txtSayi.Focus(); // Ýmleci TextBox içine odaklar
            }
        }
    }
}