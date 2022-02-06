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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double reatDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = reatDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double ereatUero = Convert.ToDouble(erate.Text);
            double esumUero = Convert.ToDouble(esum.Text);
            double eresUero = ereatUero * esumUero;
            eresSum.Text = eresUero.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double greatGriv = Convert.ToDouble(grate.Text);
            double gsumGriv = Convert.ToDouble(gsum.Text);
            double gresGriv = greatGriv * gsumGriv;
            gresSum.Text = gresGriv.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double areatA = Convert.ToDouble(arate.Text);
            double asumA = Convert.ToDouble(asum.Text);
            double aresA = areatA * asumA;
            aresSum.Text = aresA.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double dumA = Convert.ToDouble(dum.Text);
            double d = 39.37;
            double metA = dumA * d;
            met.Text = dum.ToString();
        }
    }
}
