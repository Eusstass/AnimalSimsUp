using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalSimsUp
{
    public abstract class ITier
    {
        protected int Art;

        public int FutterValue;

        public int LiebeValue;

        public int SchlafenValue;

        public void Futtern()
        {
            throw new System.NotImplementedException();
        }

        public void Schlafen()
        {
            throw new System.NotImplementedException();
        }

        public void Streicheln()
        {
            throw new System.NotImplementedException();
        }
    }
}