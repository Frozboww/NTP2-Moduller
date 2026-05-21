using System;
using System.Drawing;
using System.Windows.Forms;

namespace modul3_2
{
    public partial class Form1 : Form
    {
        // Tasarým nesnelerini kod ile tanýmlýyoruz
        private Label lblBaslik;
        private TextBox txtKatNo;
        private Button btnPlanGoster;
        private ListBox lstBirimler;

        public Form1()
        {
            // Pencere özelliklerini kod ile ayarlýyoruz
            this.Text = "Okul Kat Yerleþim Planý (modul3_2)";
            this.Width = 450;
            this.Height = 400;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Tasarýmý oluþturan metodu çaðýrýyoruz
            TasarimiOlustur();
        }

        // Tümüyle koddan oluþan arayüz tasarýmý
        private void TasarimiOlustur()
        {
            // 1. Etiket (Label) Ayarlarý
            lblBaslik = new Label();
            lblBaslik.Text = "Kat Numarasý Giriniz (0, 1, 2 veya Zemin):";
            lblBaslik.Location = new Point(30, 30);
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(lblBaslik);

            // 2. Metin Kutusu (TextBox) Ayarlarý
            txtKatNo = new TextBox();
            txtKatNo.Location = new Point(30, 55);
            txtKatNo.Width = 150;
            txtKatNo.Font = new Font("Arial", 10, FontStyle.Regular);
            this.Controls.Add(txtKatNo);

            // 3. Buton (Button) Ayarlarý
            btnPlanGoster = new Button();
            btnPlanGoster.Text = "Yerleþim Planýný Göster";
            btnPlanGoster.Location = new Point(200, 52);
            btnPlanGoster.Width = 180;
            btnPlanGoster.Height = 28;
            btnPlanGoster.Font = new Font("Arial", 9, FontStyle.Bold);
            // Butona týklama olayýný (Event) koda baðlýyoruz
            btnPlanGoster.Click += new EventHandler(btnPlanGoster_Click);
            this.Controls.Add(btnPlanGoster);

            // 4. Liste Kutusu (ListBox) Ayarlarý
            lstBirimler = new ListBox();
            lstBirimler.Location = new Point(30, 100);
            lstBirimler.Width = 375;
            lstBirimler.Height = 220;
            lstBirimler.Font = new Font("Consolas", 10, FontStyle.Regular);
            this.Controls.Add(lstBirimler);
        }

        // Butona týklandýðýnda çalýþacak sýnav sorusunun else-if kodlarý
        private void btnPlanGoster_Click(object sender, EventArgs e)
        {
            // Her yeni sorguda listeyi temizle
            lstBirimler.Items.Clear();

            // TextBox'a yazýlan metni al ve boþluklarý temizle
            string kat = txtKatNo.Text.Trim();

            // SORUDA ÝSTENEN ELSE IF YAPISI
            if (kat == "0" || kat.ToLower() == "zemin")
            {
                lstBirimler.Items.Add("=======================================");
                lstBirimler.Items.Add("           ZEMÝN KAT PLANI            ");
                lstBirimler.Items.Add("=======================================");
                lstBirimler.Items.Add(" 1. Müdür Odasý");
                lstBirimler.Items.Add(" 2. Müdür Yardýmcýsý Odasý");
                lstBirimler.Items.Add(" 3. Memur Odasý ve Arþiv");
                lstBirimler.Items.Add(" 4. Okul Kantini ve Danýþma");
            }
            else if (kat == "1")
            {
                lstBirimler.Items.Add("=======================================");
                lstBirimler.Items.Add("             1. KAT PLANI              ");
                lstBirimler.Items.Add("=======================================");
                lstBirimler.Items.Add(" 1. Öðretmenler Odasý");
                lstBirimler.Items.Add(" 2. 9-A, 9-B ve 9-C Sýnýflarý");
                lstBirimler.Items.Add(" 3. Rehberlik Servisi");
                lstBirimler.Items.Add(" 4. Sistem Odasý");
            }
            else if (kat == "2")
            {
                lstBirimler.Items.Add("=======================================");
                lstBirimler.Items.Add("             2. KAT PLANI              ");
                lstBirimler.Items.Add("=======================================");
                lstBirimler.Items.Add(" 1. Biliþim Teknolojileri Laboratuvarý");
                lstBirimler.Items.Add(" 2. 10-A ve 10-B Sýnýflarý");
                lstBirimler.Items.Add(" 3. Okul Kütüphanesi");
                lstBirimler.Items.Add(" 4. Fen Laboratuvarý");
            }
            else
            {
                // Tanýmlý katlar dýþýnda bir giriþ yapýlýrsa
                MessageBox.Show("Lütfen geçerli bir kat numarasý giriniz!\nÖrnek: 0, 1, 2 veya Zemin", "Hatalý Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}