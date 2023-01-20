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

        // Hier werden die Gehege Daten aktualisiert
        private void aktualisierenGehege()
        {
            Global.GehegeList[Global.TierList[Global.TierList.Count() - 1].position].tierGehege = Global.TierList[Global.TierList.Count() - 1].tier;
            Global.mainWindowImages[Global.TierList[Global.TierList.Count() - 1].position].Source = Global.GehegeList[Global.TierList[Global.TierList.Count() - 1].position].tierGehege.tierbild;
            Global.shop1Images[Global.TierList[Global.TierList.Count() - 1].position].Source = Global.GehegeList[Global.TierList[Global.TierList.Count() - 1].position].tierGehege.tierbild;
        }

        //Check for Doubles
        private void checkDoubleEntry()
        {
            for (int i = 0; i < Global.TierList.Count(); i++)
            {
                if (Global.TierList[i].position == MainWindow.shop1Window.positionGehege)
                {
                    Global.TierList.RemoveAt(i);
                }
            }
        }

        //Opossom Kaufen
        private void KaufenTierShopOpossom_Click(object sender, RoutedEventArgs e)
        {
            checkDoubleEntry();
            Global.TierList.Add(new GehegeSafe(MainWindow.shop1Window.positionGehege, new Opossom()));
            aktualisierenGehege ();
            Global.Geld -= 100;
            MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
        }

        //Quoakka Kaufen
        private void KaufenTierShopQuokka_Click(object sender, RoutedEventArgs e)
        {
            checkDoubleEntry();
            Global.TierList.Add(new GehegeSafe(MainWindow.shop1Window.positionGehege, new Quokka()));
            aktualisierenGehege();
            Global.Geld -= 200;
            MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
        }

        //Tiger kaufen
        private void KaufenTierShopTiger_Click(object sender, RoutedEventArgs e)
        {
            checkDoubleEntry();
            Global.TierList.Add(new GehegeSafe(MainWindow.shop1Window.positionGehege, new Tiger()));
            aktualisierenGehege();
            Global.Geld -= 300;
            MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
        }

        private void KaufenTierShopGiraffe_Click(object sender, RoutedEventArgs e)
        {
            checkDoubleEntry();
            Global.TierList.Add(new GehegeSafe(MainWindow.shop1Window.positionGehege, new Giraffe()));
            aktualisierenGehege();
            Global.Geld -= 400;
            MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
        }
    }
}
