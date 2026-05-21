using System;
using System.Windows;
using System.Windows.Controls;

namespace modul1_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Bileşenler yüklendikten hemen sonra çalışacak kodlar
            int i = 30;
            textBox1.Text = i.ToString();
        }
    }
}