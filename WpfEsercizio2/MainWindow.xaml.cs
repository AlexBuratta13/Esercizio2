﻿using Es2Linbr;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEsercizio2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_calcola_Click(object sender, RoutedEventArgs e)
        {
            double n = double.Parse(txt_inserisci.Text);
            int n1;
            if (Utilità.VericaIntero(n))
            {
                lbl_risultato.Content = "il numero è intero";
                n1 = (int)n;
            }
            else
            {
                lbl_risultato.Content = "il numero non è intero";
                n1 = Utilità.Arrotonda(n);
            }
            if (Utilità.Pari_Dispari(n1))
            {
                lbl_risultato.Content += "il numero è pari";
            }
            else
            {
                lbl_risultato.Content += "il numero è dispari";
            }
        }
    }
}
