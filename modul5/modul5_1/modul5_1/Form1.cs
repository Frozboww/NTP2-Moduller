using System;
using System.Drawing;
using System.Windows.Forms;

namespace modul5_1
{
    public partial class Form1 : Form
    {
        // Yönergede istenen TextBox nesnelerini kod seviyesinde bildiriyoruz
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;

        // Diðer görsel bileþenlerimiz
        private Button btnHesapla;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;

        public Form1()
        {
            // Form penceresinin temel baþlýk ve boyut ayarlarý
            this.Text = "Metot Kullanimi Odevi (modul5_1)";
            this.Width = 360;
            this.Height = 300;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Dinamik tasarým metodumuzu tetikliyoruz
            ArayuzuOlustur();
        }

        // ToolBox kullanmadan tüm yerleþimi kodla çiziyoruz (Çakýþmalarý önlemek için en güvenli yol)
        private void ArayuzuOlustur()
        {
            // 1. Sayý Etiketi ve Giriþ Kutusu
            lbl1 = new Label() { Text = "1.sayý", Location = new Point(40, 45), AutoSize = true };
            textBox1 = new TextBox() { Location = new Point(130, 42), Width = 150 };
            this.Controls.Add(lbl1);
            this.Controls.Add(textBox1);

            // 2. Sayý Etiketi ve Giriþ Kutusu
            lbl2 = new Label() { Text = "2.sayý", Location = new Point(40, 85), AutoSize = true };
            textBox2 = new TextBox() { Location = new Point(130, 82), Width = 150 };
            this.Controls.Add(lbl2);
            this.Controls.Add(textBox2);

            // Hesapla Butonu
            btnHesapla = new Button() { Text = "hesapla", Location = new Point(130, 130), Width = 150, Height = 30, Font = new Font(this.Font, FontStyle.Bold) };
            // Yönerge Adýmý: Button nesnesinin "click" özelliðine islem(); ifadesini ekliyoruz
            btnHesapla.Click += new EventHandler(btnHesapla_Click);
            this.Controls.Add(btnHesapla);

            // Sonuç Etiketi ve Gösterge Kutusu
            lbl3 = new Label() { Text = "Sonuç", Location = new Point(40, 190), AutoSize = true, Font = new Font(this.Font, FontStyle.Bold) };
            textBox3 = new TextBox() { Location = new Point(130, 187), Width = 150, ReadOnly = true, BackColor = Color.LightGray };
            this.Controls.Add(lbl3);
            this.Controls.Add(textBox3);
        }

        // Buton týklama olayý (Event)
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            islem();
        }

        // Yönerge Adýmý: Button nesnesinin click özelliðinin sonlandýrýldýðý küme parantezinin hemen altýna public void islem() metodunu tanýmlayýnýz.
        public void islem()
        {
            // Güvenlik amaçlý boþ alan kontrolü
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Lütfen 1. ve 2. sayý alanlarýný doldurunuz!", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Yönerge Adýmý: Tanýmladýðýnýz metot içerisinde textBox1 ve textBox2 nesnelerini toplayarak texbox3 nesnesine aktarýnýz.
                // Yönerge Adýmý: Gerekli tür dönüþümlerini yapmayý unutmayýnýz (string -> int ve int -> string).
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int toplam = sayi1 + sayi2;

                textBox3.Text = toplam.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayý alanlarýna sadece geçerli tam sayýlar giriniz!", "Hatalý Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
    }
}