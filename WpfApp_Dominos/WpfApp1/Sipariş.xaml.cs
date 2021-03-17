using System;
using System.Collections.Generic;
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
    /// Interaction logic for Sipariş.xaml
    /// </summary>
    public partial class Sipariş : Window
    {
        Sepet st = new Sepet();
        public string adres;
        public Sipariş()
        {
            InitializeComponent();
        }

        private void Seç_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Pizza1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ürün Sepete Eklendi");
            st.siparişler.Text += isim1.Text + ' ';
            decimal a, b,c;
            a = Convert.ToDecimal(fiyat1.Text.ToString());
            b = Convert.ToDecimal(st.fiyat.Text.ToString());
            c = a + b;
            st.fiyat.Text = c.ToString();


        }

        private void Pizza2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ürün Sepete Eklendi");
            st.siparişler.Text += isim2.Text + ' ';
            decimal a, b,c;
            a = Convert.ToDecimal(fiyat2.Text.ToString());
            b = Convert.ToDecimal(st.fiyat.Text.ToString());
            c = a + b;
            st.fiyat.Text = c.ToString();
        }

        private void Pizza3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ürün Sepete Eklendi");
            st.siparişler.Text += isim3.Text + ' ';
            decimal a, b,c;
            a = Convert.ToDecimal(fiyat3.Text.ToString());
            b = Convert.ToDecimal(st.fiyat.Text.ToString());
            c = a + b;
            st.fiyat.Text = c.ToString();
        }

        private void Içecek1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ürün Sepete Eklendi");
            st.siparişler.Text += ad1.Text + ' ';
            decimal a, b,c;
            a = Convert.ToDecimal(ücret1.Text.ToString());
            b = Convert.ToDecimal(st.fiyat.Text.ToString());
            c = a + b;
            st.fiyat.Text = c.ToString();
        }

        private void Içecek2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ürün Sepete Eklendi");
            st.siparişler.Text += ad2.Text + ' ';
            decimal a, b,c;
            a = Convert.ToDecimal(ücret2.Text.ToString());
            b = Convert.ToDecimal(st.fiyat.Text.ToString());
            c = a + b;
            st.fiyat.Text = c.ToString();
        }

        private void Içecek3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ürün Sepete Eklendi");
            st.siparişler.Text += ad3.Text + ' ';
            decimal a, b,c;
            a = Convert.ToDecimal(ücret3.Text.ToString());
            b = Convert.ToDecimal(st.fiyat.Text.ToString());
            c = a + b;
            st.fiyat.Text = c.ToString();
        }

        private void Sepete_git_Click(object sender, RoutedEventArgs e)
        {
            if (st.fiyat.Text!="0")
            {
                st.Show();
                st.A_text.Text = adres.ToString();
               
            }
            else
            {
                MessageBox.Show("Ürün Seçmediniz");
            }
            
        }
    }
}
