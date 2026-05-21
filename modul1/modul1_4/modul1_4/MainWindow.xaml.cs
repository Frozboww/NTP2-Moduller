using System;
using System.Windows;

namespace hesapmakinesi
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Topla butonuna tıklandığında çalışacak kodlar
        private void btnTopla_Click(object sender, RoutedEventArgs e)
        {
            int a = Int16.Parse(textBox1.Text);
            int b = Int16.Parse(textBox2.Text);
            textBox3.Text = (a + b).ToString();
        }

        // Çıkar butonuna tıklandığında çalışacak kodlar
        private void btnCikar_Click(object sender, RoutedEventArgs e)
        {
            int a = Int16.Parse(textBox1.Text);
            int b = Int16.Parse(textBox2.Text);
            textBox3.Text = (a - b).ToString();
        }

        // Çarp butonuna tıklandığında çalışacak kodlar
        private void btnCarp_Click(object sender, RoutedEventArgs e)
        {
            int a = Int16.Parse(textBox1.Text);
            int b = Int16.Parse(textBox2.Text);
            textBox3.Text = (a * b).ToString();
        }

        // Böl butonuna tıklandığında çalışacak kodlar
        private void btnBol_Click(object sender, RoutedEventArgs e)
        {
            int a = Int16.Parse(textBox1.Text);
            int b = Int16.Parse(textBox2.Text);

            // Sıfıra bölünme hatasını engellemek için basit kontrol eklenebilir
            if (b != 0)
            {
                textBox3.Text = (a / b).ToString();
            }
            else
            {
                textBox3.Text = "Hata!";
            }
        }
    }
}