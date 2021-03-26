using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaGioco
{
    public abstract class Razza
    {
        public Schieramento schieramento { get; private set; }

        public Razza(Schieramento s)
        {
            schieramento = s;
        }
        public abstract uint GetAttacco();
        public abstract uint GetDifesa();
        public abstract bool PuoiAttaccare(Razza r);

    }
}
