using AnimalSimsUp.Klassen;
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

namespace AnimalSimsUp.windowsAnimal
{
    /// <summary>
    /// Interaktionslogik für shop2.xaml
    /// </summary>
    public partial class shop2 : UserControl
    {
        //public static shop2 shop2Window;
        //Shop1 shop1 = null;
        public shop2()
        {
            InitializeComponent();
            //shop2Window = this;
            //shop1 = Shop1.shop1Window;
        }

        private void zurückButtonShop1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop1Window;
        }

        private void KaufenTierShopOpossom_Click(object sender, RoutedEventArgs e)
        {
            if (Global.tierList.Count() < 4)
            {
                Global.tierList.Add(new Opossom());
                
                Global.gehegeImageList[MainWindow.shop1Window.shopIndex].Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/opossum.jpg", UriKind.Relative)));
                Global.shopImageList[MainWindow.shop1Window.shopIndex].Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/opossum.jpg", UriKind.Relative)));
            }

        }

        private void KaufenTierShopQuokka_Click(object sender, RoutedEventArgs e)
        {
            if (Global.tierList.Count() < 4)
            {
                Global.tierList.Add(new Quokka());

                Global.gehegeImageList[MainWindow.shop1Window.shopIndex].Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/quokka.jpg", UriKind.Relative)));
                Global.shopImageList[MainWindow.shop1Window.shopIndex].Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/quokka.jpg", UriKind.Relative)));

            }
        }

        private void KaufenTierShopTiger_Click(object sender, RoutedEventArgs e)
        {
            if (Global.tierList.Count() < 4)
            {
                Global.tierList.Add(new Tiger());

                Global.gehegeImageList[MainWindow.shop1Window.shopIndex].Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/tiger.jpg", UriKind.Relative)));
                Global.shopImageList[MainWindow.shop1Window.shopIndex].Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/tiger.jpg", UriKind.Relative)));

            }
        }

        private void KaufenTierShopGiraffe_Click(object sender, RoutedEventArgs e)
        {
            if (Global.tierList.Count() < 4)
            {
                Global.tierList.Add(new Giraffe());

                Global.gehegeImageList[MainWindow.shop1Window.shopIndex].Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/giraffe.jpeg", UriKind.Relative)));
                Global.shopImageList[MainWindow.shop1Window.shopIndex].Source = new BitmapImage(new Uri(new Uri(Directory.GetCurrentDirectory(), UriKind.Absolute), new Uri(@"../../Bilder/giraffe.jpg", UriKind.Relative)));

            }
        }
    }
}
