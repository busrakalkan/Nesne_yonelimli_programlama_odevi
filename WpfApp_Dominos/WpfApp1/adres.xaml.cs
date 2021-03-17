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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class adres : Window
    {
        public adres()
        {
            InitializeComponent();
        }

        private void T_TextChanged(object sender, TextChangedEventArgs e)
        {
            T.Text = Regex.Replace(T.Text, "[^0-9]+", "");
            
        }

        private void Ekle_Click(object sender, RoutedEventArgs e)
        {
            AnaSayfa asyf = new AnaSayfa();
            asyf.tes_tip.Text = "Adrese teslim";
            asyf.bilgi.Text = "Adres Bilgileri";
            asyf.bilgi_texti.Text = AçıklamaTexti.Text;
            asyf.Show();
            this.Close();
        }
    }
}
