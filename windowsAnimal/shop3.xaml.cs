using AnimalSimsUp.Klassen;
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

namespace AnimalSimsUp.windowsAnimal
{
    /// <summary>
    /// Interaktionslogik für shop3.xaml
    /// </summary>
    public partial class shop3 : UserControl
    {
        public shop3()
        {
            InitializeComponent();
        }

        //Die Buttons zum kaufen von Ubgrades 
        private void kaufenZusatzTier_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in Global.TierList)
            {
                if (item.position == MainWindow.shop1Window.positionGehege)
                {
                    item.anzahlDerTiere += 1;
                }
            }
        }

        private void kaufenAutoFutter_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in Global.TierList)
            {
                if (item.position == MainWindow.shop1Window.positionGehege)
                {
                    item.hasAutoFeed= true;
                }
            }
        }

        private void kaufenAutoReinigung_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in Global.TierList)
            {
                if (item.position == MainWindow.shop1Window.positionGehege)
                {
                    item.hasAutoClean = true;
                }
            }
        }

        private void zurückShop3_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop1Window;
        }
    }
}
