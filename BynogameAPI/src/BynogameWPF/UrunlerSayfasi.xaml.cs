﻿using System;
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
    /// UrunlerSayfasi.xaml etkileşim mantığı
    /// </summary>
    public partial class UrunlerSayfasi : Page
    {
        public UrunlerSayfasi()
        {
            InitializeComponent();
        }

        private void Urunler_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Urundetaylisayfa urundet = new Urundetaylisayfa();
        }
    }
}
