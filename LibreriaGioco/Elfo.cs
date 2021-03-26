using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaGioco
{
    public class Elfo:Razza
    {
        private const uint Attacco = 60;
        private const uint Difesa = 40;

        public Elfo(Schieramento s) : base(s) { }

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
