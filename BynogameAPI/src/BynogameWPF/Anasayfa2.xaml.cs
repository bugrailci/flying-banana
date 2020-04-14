using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BynogameWPF
{
    /// <summary>
    /// Anasayfa2.xaml etkileşim mantığı
    /// </summary>
    public partial class Anasayfa2 : Page
    {
        public Anasayfa2()
        {
            InitializeComponent();
        }

        private void Urunler_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void sahteTakasClick(object sender, RoutedEventArgs e)
        {

            BitmapImage geciciresim = new BitmapImage();//Resim değiştirmek için bir değişken üretiyoruz
            geciciresim.BeginInit();
            geciciresim.UriSource = new Uri("sahtehesap.jpg", UriKind.Relative); //Buraya yerleştirmek istediğimiz resimin adresini atıyoruz, ve o resim geciciresim adlı değişkenimize gidiyor
            geciciresim.EndInit();
            Slider1.Stretch = Stretch.Fill;//Bu yuklediğimiz resmin tüm imagebox'ını kaplamasını sağlıyor, yani strech liyor
            Slider1.Source = geciciresim;//Burada da resmi bi3,yani istediğimiz resimle güncelliyoruz

        }

        private void csgoClick(object sender, RoutedEventArgs e)
        {

            BitmapImage geciciresim = new BitmapImage();//Resim değiştirmek için bir değişken üretiyoruz
            geciciresim.BeginInit();
            geciciresim.UriSource = new Uri("csgo.jpg", UriKind.Relative); //Buraya yerleştirmek istediğimiz resimin adresini atıyoruz, ve o resim geciciresim adlı değişkenimize gidiyor
            geciciresim.EndInit();
            Slider1.Stretch = Stretch.Fill;//Bu yuklediğimiz resmin tüm imagebox'ını kaplamasını sağlıyor, yani strech liyor
            Slider1.Source = geciciresim;//Burada da resmi bi3,yani istediğimiz resimle güncelliyoruz


        }

        private void knight1Click(object sender, RoutedEventArgs e)
        {
            BitmapImage geciciresim = new BitmapImage();//Resim değiştirmek için bir değişken üretiyoruz
            geciciresim.BeginInit();
            geciciresim.UriSource = new Uri("knight krem.jpg", UriKind.Relative); //Buraya yerleştirmek istediğimiz resimin adresini atıyoruz, ve o resim geciciresim adlı değişkenimize gidiyor
            geciciresim.EndInit();
            Slider1.Stretch = Stretch.Fill;//Bu yuklediğimiz resmin tüm imagebox'ını kaplamasını sağlıyor, yani strech liyor
            Slider1.Source = geciciresim;//Burada da resmi bi3,yani istediğimiz resimle güncelliyoruz

        }

        private void knight2Click(object sender, RoutedEventArgs e)
        {
            BitmapImage geciciresim = new BitmapImage();//Resim değiştirmek için bir değişken üretiyoruz
            geciciresim.BeginInit();
            geciciresim.UriSource = new Uri("knightkoyu.jpg", UriKind.Relative); //Buraya yerleştirmek istediğimiz resimin adresini atıyoruz, ve o resim geciciresim adlı değişkenimize gidiyor
            geciciresim.EndInit();
            Slider1.Stretch = Stretch.Fill;//Bu yuklediğimiz resmin tüm imagebox'ını kaplamasını sağlıyor, yani strech liyor
            Slider1.Source = geciciresim;//Burada da resmi bi3,yani istediğimiz resimle güncelliyoruz
        }

        private void steamClick(object sender, RoutedEventArgs e)
        {
            BitmapImage geciciresim = new BitmapImage();//Resim değiştirmek için bir değişken üretiyoruz
            geciciresim.BeginInit();
            geciciresim.UriSource = new Uri("steamdol.jpg", UriKind.Relative); //Buraya yerleştirmek istediğimiz resimin adresini atıyoruz, ve o resim geciciresim adlı değişkenimize gidiyor
            geciciresim.EndInit();
            Slider1.Stretch = Stretch.Fill;//Bu yuklediğimiz resmin tüm imagebox'ını kaplamasını sağlıyor, yani strech liyor
            Slider1.Source = geciciresim;//Burada da resmi bi3,yani istediğimiz resimle güncelliyoruz
        }

        private void garantiClick(object sender, RoutedEventArgs e)
        {
            BitmapImage geciciresim = new BitmapImage();//Resim değiştirmek için bir değişken üretiyoruz
            geciciresim.BeginInit();
            geciciresim.UriSource = new Uri("garanti.jpg", UriKind.Relative); //Buraya yerleştirmek istediğimiz resimin adresini atıyoruz, ve o resim geciciresim adlı değişkenimize gidiyor
            geciciresim.EndInit();
            Slider1.Stretch = Stretch.Fill;//Bu yuklediğimiz resmin tüm imagebox'ını kaplamasını sağlıyor, yani strech liyor
            Slider1.Source = geciciresim;//Burada da resmi bi3,yani istediğimiz resimle güncelliyoruz
        }
    }
}

