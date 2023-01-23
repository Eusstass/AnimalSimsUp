using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AnimalSimsUp.Klassen
{
    static class Global
    {    
        //Die Listen die man braucht 
        public static List<GehegeSafe> TierList = new List<GehegeSafe>();
        public static List<Gehege> GehegeList = new List<Gehege>();
        public static List<Image> mainWindowImages = new List<Image> ();
        public static List<Image> shop1Images = new List<Image> ();
        public static List<ProgressBar> progressBarsFutter = new List<ProgressBar> ();
        public static List<ProgressBar> progressBarsPflege = new List<ProgressBar>();
        public static List<ProgressBar> progressBarsLiebe = new List<ProgressBar>();

        //Die Variablen
        public static double Zeit = 6.0;
        public static int Geld = 500;
        public static int anzahlTiere = 1;

        public static int ausgaben = 0;
        public static int einnamen = 0;

        // Die Allgeinen Funktionen
        //Hier wird die Nacht abgefraght und Ausgeführt außerdem wird sofern vorhanden der Auto Feed und Clean ausgeführt
        public static double checkNight(double Uhrzeit)
        {
            if (Uhrzeit > 22)
            {
                Uhrzeit = 6;
                for (int i = 0; i < TierList.Count(); i++)
                {
                    Geld += TierList[i].tier.gewinn * TierList[i].anzahlDerTiere;
                    einnamen += TierList[i].tier.gewinn * TierList[i].anzahlDerTiere;
                }
                MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
                runtersetzenDerWerte(30);

                for (int i = 0; i < TierList.Count(); i++)
                {
                    if (TierList[i].hasAutoClean)
                    {
                        TierList[i].tier.pflegeValue = 100;
                        changeProgressBars(TierList[i].position, i);
                    }
                    if (TierList[i].hasAutoFeed)
                    {
                        TierList[i].tier.futterValue = 100;
                        Geld -= TierList[i].tier.futterKosten * 2 * TierList[i].anzahlDerTiere;
                        ausgaben += TierList[i].tier.futterKosten * 2 * TierList[i].anzahlDerTiere;

                        changeProgressBars(TierList[i].position, i);
                        if (Geld <= 0)
                        {
                            //MainWindow.AppWindow.Close();
                            MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.gameOverScreen;
                        }
                        MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
                    }
                }
                MainWindow.nachtWindow.labelAusgaben.Content = "Ausgaben " + ausgaben + " Euro";
                MainWindow.nachtWindow.labelEinnahmen.Content = "Einnamen " + einnamen + " Euro";
                MainWindow.nachtWindow.labelGewinn.Content = "Gewinn " + (einnamen - ausgaben) + " Euro";
                MainWindow.nachtWindow.labelGeld.Content = "Geld " + Geld + " Euro";
                MainWindow.nachtWindow.labelTiere.Content = "Tiere " + anzahlTiere;
                einnamen = 0;
                ausgaben = 0;
                MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.nachtWindow;
            }
            return Uhrzeit;
        }

        //Hier wird das heruntersetzen der Tierwerte durchgeführt
        public static void runtersetzenDerWerte(int vergangeneZeit)
        {
            for (int i = 0; i < vergangeneZeit; i++)
            {
                for (int d = 0; d < TierList.Count(); d++)
                {
                    TierList[d].tier.futterValue -= 1;
                    TierList[d].tier.liebeValue -= 1;
                    TierList[d].tier.pflegeValue -= 1;
                    
                    changeProgressBars(TierList[d].position, d);
                }
            }
        }

        //Hier werden Werte hochgesetzt
        public static void hochsetztenDerWerte(int position, string was)
        {
            for (int i = 0; i < TierList.Count(); i++)
            {
                if (TierList[i].position == position)
                {
                    switch (was)
                    {
                        case "nahrung":
                            TierList[i].tier.futterValue += 20;
                            break;
                        case "liebe":
                            TierList[i].tier.liebeValue += 20;
                            break;
                        case "pflege":
                            TierList[i].tier.pflegeValue += 20;
                            break;
                        default:
                            break;
                    }
                  
                    if (TierList[i].tier.futterValue > 100)
                    {
                        TierList[i].tier.futterValue = 100;
                    }

                    else if (TierList[i].tier.pflegeValue > 100)
                    {
                        TierList[i].tier.pflegeValue = 100;
                    }

                    else if (TierList[i].tier.liebeValue > 100)
                    {
                        TierList[i].tier.liebeValue = 100;
                    }

                    changeProgressBars(TierList[i].position, i);

                }
            }
        }

        //Hier werden dei Ubdates verarbeitet
        private static void changeProgressBars(int position, int tier)
        {
            if (progressBarsFutter[position].Value > 0 && progressBarsLiebe[position].Value > 0 && progressBarsPflege[position].Value > 0)
            {
                progressBarsFutter[position].Value = TierList[tier].tier.futterValue;
                progressBarsLiebe[position].Value = TierList[tier].tier.liebeValue;
                progressBarsPflege[position].Value = TierList[tier].tier.pflegeValue;
            }
            else
            {
                MainWindow.AppWindow.contentControlAnimal.Content = MainWindow.gameOverScreen;
            }
        }      
    }
}
