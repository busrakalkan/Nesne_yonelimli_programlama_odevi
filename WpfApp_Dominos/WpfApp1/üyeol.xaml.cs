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
    /// Interaction logic for üyeol.xaml
    /// </summary>
    public partial class üyeol : Window
    {
        public üyeol()
        {
            InitializeComponent();
        }
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Service1Client servis = new Service1Client();
            int a = servis.register(username_text.Text, password_text.Text, email_text.Text);
            if (a == 1)
            {
                MessageBox.Show("Kaydınız Başarıyla Oluşturuldu");
                this.Close();
            }
            else
            {
                username_text.Text = "";
                password_text.Text = "";
                email_text.Text = "";
                MessageBox.Show("Kullanıcı Adı veya Şifre kullanılıyor tekrar deneyiniz");
            }
            servis.Close();
        }

        private void Password_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            password_text.Text = Regex.Replace(password_text.Text, "[^0-9]+", "");
        }
    }
}
