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

namespace Kostky_IT1B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Kostka[] kostky = new Kostka[6];
        //kostky[0] = new Kostka();
        //kostky[1] = new Kostka();
        //kostky[2] = new Kostka();
        //kostky[3] = new Kostka();
        //kostky[4] = new Kostka();
        //kostky[5] = new Kostka();

        Kostka[] kostky = new Kostka[] { 
            new Kostka(),
            new Kostka(),
            new Kostka(),
            new Kostka(),
            new Kostka(),
            new Kostka()
        };

        public MainWindow()
        {
            InitializeComponent();
            zobrazkostky();
        }

        private void zobrazkostky()
        {
            kostka1.Content = kostky[0].Hodnota;
            kostka2.Content = kostky[1].Hodnota;
            kostka3.Content = kostky[2].Hodnota;
            kostka4.Content = kostky[3].Hodnota;
            kostka5.Content = kostky[4].Hodnota;
            kostka6.Content = kostky[5].Hodnota;
        }

        private void btnhod_Click(object sender, RoutedEventArgs e)
        {
            foreach (var kostka in kostky)
            {
                kostka.Hod();
            }
            zobrazkostky();
            spocitejbody();
        }

        private int spocitejbody()
        {
            int body = 0;
            Dictionary<int, int> pocty = new Dictionary<int, int>();
            pocty.Add(1, 0);
            pocty.Add(2, 0);
            pocty.Add(3, 0);
            pocty.Add(4, 0);
            pocty.Add(5, 0);
            pocty.Add(6, 0);

            foreach (var kostka in kostky)
            {
                pocty[kostka.Hodnota]++;
            }

            return body;
        }

    }
}
