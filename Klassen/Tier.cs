using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimsUp.Klassen
{

    class Tier
    {
        public string art;
        protected int futterKosten;
        public int futterValue = 50;
        public int liebeValue = 50;
        public int schlafenValue = 80;

        public void fuettern()
        {
            futterValue += 60;
        }
        public void streicheln()
        {
            liebeValue+= 60;
        }
        public void schlafen()
        {
            schlafenValue += 60;
        }
        public virtual void  setArt(string art) { }
        public virtual void setFutterKosten(int futterKosten) { }

    }
}
