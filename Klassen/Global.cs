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

        public static double checkNight(double Uhrzeit)
        {
            if (Uhrzeit >= 22)
            {
                Uhrzeit = 6;
                Geld += 500;
                MainWindow.mainWindow.GeldBetrag.Content = Convert.ToString(Global.Geld) + " Euro";
                runtersetzenDerWerte(12);
            }

            return Uhrzeit;
        }

        public static void runtersetzenDerWerte(int vergangeneZeit)
        {
            for (int i = 0; i < vergangeneZeit; i++)
            {
                for (int d = 0; d < progressBarsFutter.Count(); d++)
                {
                    if (progressBarsFutter[d] != null && progressBarsLiebe[d] != null && progressBarsPflege[d] != null)
                    {
                        progressBarsFutter[d].Value -= 1;
                        progressBarsLiebe[d].Value -= 1;
                        progressBarsPflege[d].Value -= 1;

                        if (progressBarsPflege[d].Value <= 0 || progressBarsLiebe[d].Value <= 0 || progressBarsFutter[d].Value <= 0)
                        {
                            MainWindow.AppWindow.Close();
                        }
                    }


                }
            }
        }
    }
}
