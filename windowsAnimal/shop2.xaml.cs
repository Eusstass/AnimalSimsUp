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
            Global.anzahlTiere = Global.TierList.Count();
            MainWindow.mainWindow.AnzahlTiere.Content = Convert.ToString(Global.anzahlTiere) + " Tiere";
        }

        //Hier werden die ProgressBars eingeschaltet
        private void addProgressBar(bool doubleEntry)
        {
            if (Global.TierList[Global.TierList.Count() - 1].position == 1 && !doubleEntry)
            {
                Global.progressBarsFutter[1] = (MainWindow.mainWindow.Tier2Nahrung);
                Global.progressBarsLiebe[1] = (MainWindow.mainWindow.Tier2Liebe);
                Global.progressBarsPflege[1] = (MainWindow.mainWindow.Tier2Pflege);
            }
            else if (Global.TierList[Global.TierList.Count() - 1].position == 2 && !doubleEntry)
            {
                Global.progressBarsFutter[2] = (MainWindow.mainWindow.Tier3Nahrung);
                Global.progressBarsLiebe[2] = (MainWindow.mainWindow.Tier3Liebe);
                Global.progressBarsPflege[2] = (MainWindow.mainWindow.Tier3Pflege);
            }
            else if(Global.TierList[Global.TierList.Count() - 1].position == 3 && !doubleEntry)
            {
                Global.progressBarsFutter[3] = (MainWindow.mainWindow.Tier4Nahrung);
                Global.progressBarsLiebe[3] = (MainWindow.mainWindow.Tier4Liebe);
                Global.progressBarsPflege[3] = (MainWindow.mainWindow.Tier4Pflege);
            }
            else if (Global.TierList[Global.TierList.Count() - 1].position == 0 && !doubleEntry)
            {
                Global.progressBarsFutter[0] = (MainWindow.mainWindow.Tier1Nahrung);
                Global.progressBarsLiebe[0] = (MainWindow.mainWindow.Tier1Liebe);
                Global.progressBarsPflege[0] = (MainWindow.mainWindow.Tier1Pflege);
            }
        }

        //Check for Doubles
        private bool checkDoubleEntry()
        {
            bool duplikat = false;
            for (int i = 0; i < Global.TierList.Count(); i++)
            {
                if (Global.TierList[i].position == MainWindow.shop1Window.positionGehege)
                {
                    Global.TierList.RemoveAt(i);
                    duplikat = true;
                }
            }
            return duplikat;
        }

        //Opossom Kaufen
        private void KaufenTierShopOpossom_Click(object sender, RoutedEventArgs e)
        {
            bool doppelterEintrag = checkDoubleEntry();
            Global.TierList.Add(new GehegeSafe(MainWindow.shop1Window.positionGehege, new Opossom()));
            addProgressBar(doppelterEintrag);
            aktualisierenGehege ();
            Global.Geld -= 100;
            Global.ausgaben += 100;
            MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
            if (Global.Geld <= 0)
            {
                //MainWindow.AppWindow.Close();
                MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.gameOverScreen;
            }
        }

        //Quoakka Kaufen
        private void KaufenTierShopQuokka_Click(object sender, RoutedEventArgs e)
        {
            bool doppelterEintrag = checkDoubleEntry();
            Global.TierList.Add(new GehegeSafe(MainWindow.shop1Window.positionGehege, new Quokka()));
            addProgressBar(doppelterEintrag);
            aktualisierenGehege();
            Global.Geld -= 200;
            Global.ausgaben += 200;
            MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
            if (Global.Geld <= 0)
            {
                //MainWindow.AppWindow.Close();
                MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.gameOverScreen;
            }
        }

        //Giraffe kaufen
        private void KaufenTierShopTiger_Click(object sender, RoutedEventArgs e)
        {
            bool doppelterEintrag = checkDoubleEntry();
            Global.TierList.Add(new GehegeSafe(MainWindow.shop1Window.positionGehege, new Giraffe()));
            addProgressBar(doppelterEintrag);
            aktualisierenGehege();
            Global.Geld -= 400;
            Global.ausgaben += 400;
            MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
            if (Global.Geld <= 0)
            {
                //MainWindow.AppWindow.Close();
                MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.gameOverScreen;
            }
        }

        //Tiger Kaufen
        private void KaufenTierShopGiraffe_Click(object sender, RoutedEventArgs e)
        {
            bool doppelterEintrag = checkDoubleEntry();
            Global.TierList.Add(new GehegeSafe(MainWindow.shop1Window.positionGehege, new Tiger()));
            addProgressBar(doppelterEintrag);
            aktualisierenGehege();
            Global.Geld -= 300;
            Global.ausgaben += 300;
            MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
            if (Global.Geld <= 0)
            {
                //MainWindow.AppWindow.Close();
                MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.gameOverScreen;
            }
        }
    }
}
