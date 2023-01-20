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
        public static int Zeit;
        public static int Geld;
    }
}
