﻿using AnimalSimsUp.Klassen;
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

namespace AnimalSimsUp
{
    /// <summary>
    /// Interaktionslogik für Shop1.xaml
    /// </summary>
    public partial class Shop1 : UserControl
    {
        public int positionGehege = 0;
        public Shop1()
        {
            InitializeComponent();
        }
        
        //Dir Verkaufs Funktion
        private void verkauf(int _position)
        {
            for (int i = 0; i < Global.TierList.Count(); i++)
            {
                if (Global.TierList[i].position == _position)
                {
                    Global.Geld += (Global.TierList[i].tier.kosten / 2 * Global.TierList[i].anzahlDerTiere);
                    Global.einnamen += (Global.TierList[i].tier.kosten / 2 * Global.TierList[i].anzahlDerTiere);
                    MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";

                    Global.GehegeList[_position].tierGehege = null;
                    Global.TierList.RemoveAt(i);

                    Global.mainWindowImages[this.positionGehege].Source = null;
                    Global.shop1Images[this.positionGehege].Source = null;

                    Global.progressBarsLiebe[positionGehege] = null;
                    Global.progressBarsPflege[positionGehege] = null;
                    Global.progressBarsFutter[positionGehege] = null;

                    Global.anzahlTiere = Global.TierList.Count();
                    MainWindow.mainWindow.AnzahlTiere.Content = Convert.ToString(Global.anzahlTiere) + " Tiere";
                }
            }
        }

        //Der Zurück Knopf
        private void zurückButtonShop1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.mainWindow;
        }

        //Die Kauf Buttons
        private void KaufenGehege1_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop2Window;
            this.positionGehege = 0;
        }

        private void KaufenGehege2_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop2Window;
            this.positionGehege = 1;
        }

        private void KaufenGehege3_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop2Window;
            this.positionGehege = 2;
        }

        private void KaufenGehege_Click(object sender, RoutedEventArgs e)
        {
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = AnimalSimsUp.MainWindow.shop2Window;
            this.positionGehege = 3;
        }

        //Die Verkauf Buttons
        private void VerkaufenGehege1_Click(object sender, RoutedEventArgs e)
        {
            this.positionGehege = 0;
            verkauf(this.positionGehege);
        }

        private void VerkaufenGehege2_Click(object sender, RoutedEventArgs e)
        {
            this.positionGehege = 1;
            verkauf(this.positionGehege);
        }

        private void VerkaufenGehege3_Click(object sender, RoutedEventArgs e)
        {
            this.positionGehege = 2;
            verkauf(this.positionGehege);
        }

        private void VerkaufenGehege_Click(object sender, RoutedEventArgs e)
        {
            this.positionGehege = 3;
            verkauf(this.positionGehege);
        }

        //Die Buttons zum Kaufen der Ubgrades
        private void UpgradesGehege3_Click(object sender, RoutedEventArgs e)
        {
            this.positionGehege = 0;

            foreach (var item in Global.TierList)
            {
                if(item.position == this.positionGehege)
                {
                    MainWindow.shop3Window.tierDazuKaufenImage.Source = item.tier.tierbild;
                    MainWindow.shop3Window.kaufenZusatzTier.Content = item.tier.kosten + " Euro";
                }
            }
            
            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.shop3Window;
        }

        private void UpgradesGehege1_Click(object sender, RoutedEventArgs e)
        {
            this.positionGehege = 1;

            foreach (var item in Global.TierList)
            {
                if (item.position == this.positionGehege)
                {
                    MainWindow.shop3Window.tierDazuKaufenImage.Source = item.tier.tierbild;
                    MainWindow.shop3Window.kaufenZusatzTier.Content = item.tier.kosten + " Euro";
                }
            }

            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.shop3Window;
        }

        private void UpgradesGehege2_Click(object sender, RoutedEventArgs e)
        {
            this.positionGehege = 2;

            foreach (var item in Global.TierList)
            {
                if (item.position == this.positionGehege)
                {
                    MainWindow.shop3Window.tierDazuKaufenImage.Source = item.tier.tierbild;
                    MainWindow.shop3Window.kaufenZusatzTier.Content = item.tier.kosten + " Euro";
                }
            }

            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.shop3Window;
        }

        private void UpgradesGehege4_Click(object sender, RoutedEventArgs e)
        {
            this.positionGehege = 3;

            foreach (var item in Global.TierList)
            {
                if (item.position == this.positionGehege)
                {
                    MainWindow.shop3Window.tierDazuKaufenImage.Source = item.tier.tierbild;
                    MainWindow.shop3Window.kaufenZusatzTier.Content = item.tier.kosten + " Euro";
                }
            }

            AnimalSimsUp.MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.shop3Window;
        }
    }
}
