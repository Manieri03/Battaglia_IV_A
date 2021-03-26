using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaGioco
{
    public abstract class Razza
    {
        public Schieramento schieramento { get; set; }

        public abstract uint GetAttacco();
        public abstract uint GetDifesa();
        public abstract bool PuoiAttaccare(Razza r);

    }
}
