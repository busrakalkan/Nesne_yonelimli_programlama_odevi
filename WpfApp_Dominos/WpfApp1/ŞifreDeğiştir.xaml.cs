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
    /// Interaction logic for ŞifreDeğiştir.xaml
    /// </summary>
    public partial class ŞifreDeğiştir : Window
    {
        public ŞifreDeğiştir()
        {
            InitializeComponent();
        }

        private void Şifre_değiştir_Click(object sender, RoutedEventArgs e)
        {
            if (yenişifre_text.Text == conşifre_text.Text)
            {
                Service1Client servis = new Service1Client();
                int a = servis.şifre_değiştir(username_text.Text, password_text.Text,yenişifre_text.Text);
                if (a == 0)
                {
                    MessageBox.Show("Kullanıcı adını yanlış girdiniz");
                }
                else if(a==1)
                {
                    MessageBox.Show("Şifreyi yanlış girdiniz");
               
                }
                else
                {
                    MessageBox.Show("Şifreniz başarıyla değiştirilmiştir.");
                    this.Close();
                }
                servis.Close();
            }
            else
            {
                MessageBox.Show("Yeni şifreyi yanlış girdiniz");
            }
            
        }
        private void Password_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            password_text.Text = Regex.Replace(password_text.Text, "[^0-9]+", "");
        }
    }
}
