using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimsUp.Klassen
{
    class Gehege
    {
        public Tier tierGehege;
        public int position;

        public Gehege(int _porsition)
        {
            Global.GehegeList.Add(this);
            this.position = _porsition;
        }

    }

    class GehegeSafe
    {
        public int position;
        public Tier tier;

        public GehegeSafe(int _porsition,Tier _tier) 
        {
            this.tier = _tier;
            this.position = _porsition;
        }
    }
}
