using System;
using System.Collections.Generic;
using System.IO;
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
        Dictionary<int, ImageBrush> images = new Dictionary<int, ImageBrush>();
        public MainWindow()
        {
            InitializeComponent();
            images.Add(1, new ImageBrush(GetImage(Properties.Resources.dice_1)));
            images.Add(2, new ImageBrush(GetImage(Properties.Resources.dice_2)));
            images.Add(3, new ImageBrush(GetImage(Properties.Resources.dice_3)));
            images.Add(4, new ImageBrush(GetImage(Properties.Resources.dice_4)));
            images.Add(5, new ImageBrush(GetImage(Properties.Resources.dice_5)));
            images.Add(6, new ImageBrush(GetImage(Properties.Resources.dice_6)));
            zobrazkostky();
        }

        private void Zobrazkostku(Rectangle rectangle, int cislo)
        {
            rectangle.Fill = images[cislo];
        }

        private void zobrazkostky()
        {
            Zobrazkostku(k1, kostky[0].Hodnota);
            Zobrazkostku(k2, kostky[1].Hodnota);
            Zobrazkostku(k3, kostky[2].Hodnota);
            Zobrazkostku(k4, kostky[3].Hodnota);
            Zobrazkostku(k5, kostky[4].Hodnota);
            Zobrazkostku(k6, kostky[5].Hodnota);
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

        private ImageSource GetImage(byte[] resource)
        {
            MemoryStream memoryStream = new MemoryStream(resource);
            BitmapFrame bitmapFrame = BitmapFrame.Create(memoryStream);
            Image image = new Image();
            image.Source = bitmapFrame;
            return image.Source;
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
