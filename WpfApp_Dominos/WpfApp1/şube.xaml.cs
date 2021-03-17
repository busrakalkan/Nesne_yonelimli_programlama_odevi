using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
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
    /// Interaction logic for şube.xaml
    /// </summary>
    public partial class şube : Window
    {
        public şube()
        {
            InitializeComponent();
        }
        private string[] İstİlçe()
        {
            string[] strArray = {
                    "Bahçelievler",
                    "Güngören",
                    "Avcılar",
            };
            return strArray;
        }
        private string[] Ylvİlçe()
        {
            string[] strArray = {
                "Merkez",
                "Çiflikköy",
            };
            return strArray;
        }
        private void Illler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            if (illler.SelectedIndex == 0)
            {
                //ComboBox1.ItemsSource = LoadComboBoxData(); 
                ilçeler.ItemsSource = İstİlçe();
            }
            if (illler.SelectedIndex == 1)
            {
                ilçeler.ItemsSource = Ylvİlçe();
            }
        }

        private void Seç_Click(object sender, RoutedEventArgs e)
        {
            AnaSayfa asyf = new AnaSayfa();
            asyf.tes_tip.Text = "Gel Al";
            asyf.bilgi.Text = "Şube Bilgileri";
            asyf.bilgi_texti.Text = illler.Text + '\\' + ilçeler.Text;
            asyf.Show();
            this.Close();
        }
    }

}