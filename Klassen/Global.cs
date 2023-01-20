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
        public static List<GehegeSafe> TierList = new List<GehegeSafe>();
        public static List<Gehege> GehegeList = new List<Gehege>();
        public static List<Image> mainWindowImages = new List<Image> ();
        public static List<Image> shop1Images = new List<Image> ();
        public static double Zeit = 6.0;
        public static int Geld = 100;
    }
}
