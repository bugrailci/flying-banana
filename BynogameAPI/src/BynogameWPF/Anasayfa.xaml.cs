﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;

namespace BynogameWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new Anasayfa2();
        }

        private void BynoClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new Anasayfa2();
        }

        private void b1click(object sender, RoutedEventArgs e)
        {
            Main.Content = new UrunlerSayfasi();
        }

        

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }

        

        private void ItemSkinClick3(object sender, RoutedEventArgs e)
        {
            Main.Content = new UrunlerSayfasi();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Uyepencere uye = new Uyepencere();
            uye.Show();
        }
    }
}
