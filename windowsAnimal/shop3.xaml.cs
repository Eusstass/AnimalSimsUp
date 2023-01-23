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
                    Global.Geld -= item.tier.kosten;
                    Global.ausgaben += item.tier.kosten;
                    MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
                    Global.anzahlTiere += 1;
                    MainWindow.mainWindow.AnzahlTiere.Content = Convert.ToString(Global.anzahlTiere) + " Tiere";
                }
            }

            if (Global.Geld <= 0)
            {
                //MainWindow.AppWindow.Close();
                MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.gameOverScreen;
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

            Global.Geld -= 500;
            Global.ausgaben += 500;
            if (Global.Geld <= 0)
            {
                //MainWindow.AppWindow.Close();
                MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.gameOverScreen;
            }
            MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
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

            Global.Geld -= 500;
            Global.ausgaben += 500;
            if (Global.Geld <= 0)
            {
                //MainWindow.AppWindow.Close();
                MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.gameOverScreen;
            }
            MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
        }

        private void zurückShop3_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop1Window;
        }
    }
}
