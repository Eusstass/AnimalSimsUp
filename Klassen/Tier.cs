using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace AnimalSimsUp.Klassen
{
    class Tier 
    {
        public string art;
        public int futterKosten = 20;
        public BitmapImage tierbild;
        public int kosten;
        public int gewinn;

        public int futterValue = 50;
        public int liebeValue = 50;
        public int pflegeValue = 50;

        public void fuettern() 
        {
            futterValue += 10;
        }
        public void liebe() 
        {
            liebeValue += 10;
        }
        public void pflege() 
        {
            pflegeValue += 10;
        }

        public virtual void setArt() { }
        public virtual void fKosten() { }
    }
}
