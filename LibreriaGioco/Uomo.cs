using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaGioco
{
    public class Uomo : Razza
    {
        private const uint Attacco=40;
        private const uint Difesa = 70;

        public Uomo() : base()
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
