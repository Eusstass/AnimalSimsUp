using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalSimsUp
{
    public class Tier : ITier
    {
        public int FutterValue;
        public int SchlafenValue;
        public int LiebeValue;
        protected int Art;

        public Gehege Gehege
        {
            get => default;
            set
            {
            }
        }

        public void Futtern()
        {
            throw new System.NotImplementedException();
        }

        public void Streicheln()
        {
            throw new System.NotImplementedException();
        }

        public void Schlafen()
        {
            throw new System.NotImplementedException();
        }
    }
}