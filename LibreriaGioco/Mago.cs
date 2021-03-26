using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaGioco
{
    public class Mago:Razza
    {
        private const uint Attacco = 90;
        private const uint Difesa = 35;

        public Mago() : base()
        {
            schieramento = Schieramento.Bene;
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
                return false;
            }
            else
                return true;
        }
    }
}
