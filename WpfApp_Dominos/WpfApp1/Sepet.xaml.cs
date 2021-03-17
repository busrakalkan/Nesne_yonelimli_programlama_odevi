using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.ServiceReference1;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Sepet.xaml
    /// </summary>
    public partial class Sepet : Window
    {
        public Sepet()
        {
            InitializeComponent();
        }

        private void Sipariş_ver_Click(object sender, RoutedEventArgs e)
        {
            Service1Client servis = new Service1Client();
           
            int a=servis.login(username_text.Text, password_text.Text,A_text.Text,siparişler.Text);
            if (a==1)
            {
                MessageBox.Show("Siparişiniz Başarıyla Alınmıştır");
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış");
            }
            servis.Close();
            
        }
        
        private void password_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            password_text.Text = Regex.Replace(password_text.Text, "[^0-9]+", "");
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            üyeol ü = new üyeol();
            ü.Show();
        }

        private void Şifre_değiş_Click(object sender, RoutedEventArgs e)
        {
            ŞifreDeğiştir sd = new ŞifreDeğiştir();
            sd.Show();
        }
    }
}
