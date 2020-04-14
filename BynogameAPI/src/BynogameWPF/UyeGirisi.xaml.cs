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
    /// UyeGirisi.xaml etkileşim mantığı
    /// </summary>
    public partial class UyeGirisi : Page
    {
        public UyeGirisi()
        {
            InitializeComponent();
        }

        private void girisyap(object sender, RoutedEventArgs e)
        {
            string email, sifre;
            email = epostabox.Text.ToString();
            sifre = sifrebox.Text.ToString();
            sifrekontrol(email, sifre);
        }

        public void sifrekontrol(string a,string b)
        {
            if(a=="Bynogame" || b=="1111")
            {
                MessageBox.Show("Başarılı \n Yönlendiriliyorsunuz...");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
        }
    }
}
