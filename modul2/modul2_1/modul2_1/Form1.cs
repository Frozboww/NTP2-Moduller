using System;
using System.Windows.Forms;

namespace modul2_1
{
    // 1. Adým: Günler adýnda numaralandýrma yapýsýný tanýmlýyoruz
    enum Gunler
    {
        Pazartesi, Salý, Çarþamba, Perþembe, Cuma, Cumartesi, Pazar
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Form açýldýðýnda Load metodunu çalýþtýrmasýný bilgisayara elinle söylüyorsun:
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        // Form yüklendiðinde çalýþacak olay (Form1_Load)
        private void Form1_Load(object sender, EventArgs e)
        {
            // 2. Adým: Numaralandýrmadaki tüm deðerleri string bir diziye alýyoruz
            string[] gunListe = Enum.GetNames(typeof(Gunler));

            // 3. Adým: Foreach döngüsü yardýmýyla dizideki günleri ComboBox'a aktarýyoruz
            foreach (string gun in gunListe)
            {
                comboBox1.Items.Add(gun);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}