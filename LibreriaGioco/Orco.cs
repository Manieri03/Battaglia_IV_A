using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaGioco
{
    public class Orco:Razza
    {
        private const uint Attacco = 55;
        private const uint Difesa = 50;

        public Orco(Schieramento s) : base(s) { }

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
