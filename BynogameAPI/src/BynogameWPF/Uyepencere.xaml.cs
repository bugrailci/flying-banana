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
using System.Windows.Shapes;

namespace BynogameWPF
{
    /// <summary>
    /// Uyepencere.xaml etkileşim mantığı
    /// </summary>
    public partial class Uyepencere : Window
    {
        public Uyepencere()
        {
            InitializeComponent();
            uyepen.Content = new UyeGirisi();
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {

        }
    }
}
