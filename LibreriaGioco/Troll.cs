using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaGioco
{
    public class Troll:Razza
    {
        private const uint Attacco = 70;
        private const uint Difesa = 70;

        public Troll() : base()
        {
            schieramento = Schieramento.Male;
        }

        public override uint GetAttacco()
        {
            return Attacco;
        }

        public override uint GetDifesa()
        {
            return Difesa;
        }

        public override bool PuoiAttaccare(Razza r)
        {
            if (r.schieramento == Schieramento.Bene)
            {
                return true;
            }
            else
                return false;
        }

    }
}
