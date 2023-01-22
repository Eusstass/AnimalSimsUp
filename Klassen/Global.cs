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
        public static int Geld = 10000;
        public static int anzahlTiere = 0;

        // Die Allgeinen Funktionen
        //Hier wird die Nacht abgefraght und Ausgeführt
        public static double checkNight(double Uhrzeit)
        {
            if (Uhrzeit >= 22)
            {
                Uhrzeit = 6;
                for (int i = 0; i < TierList.Count(); i++)
                {
                    Geld += TierList[i].tier.gewinn;
                }
                MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
                runtersetzenDerWerte(12);
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
            switch (was)
            {
                case "nahrung":  
                    TierList[position].tier.futterValue += 20; 
                    break;
                case "liebe":
                    TierList[position].tier.liebeValue += 20;
                    break;
                case "pflege":
                    TierList[position].tier.pflegeValue += 20;
                    break;
                default:
                    break;
            }
            
            changeProgressBars(TierList[position].position, position);          
        }

        //Hier werden dei Ubdates verarbeitet
        private static void changeProgressBars(int position, int tier)
        {
            progressBarsFutter[position].Value = TierList[tier].tier.futterValue;
            progressBarsLiebe[position].Value = TierList[tier].tier.liebeValue;
            progressBarsPflege[position].Value = TierList[tier].tier.pflegeValue;
        }      
    }
}
