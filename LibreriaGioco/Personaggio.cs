using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaGioco
{
    public class Personaggio
    {
        public uint Vita;
        private Razza razza;
        public uint Exp;
        public string Nome { get; private set; }
        public Schieramento schieramento { get; private set; }
        public uint Attacco { get; private set; }
        public uint Difesa { get; private set; }
        
        

        public Personaggio(string nome, Razza razza)
        {
            Nome = nome;
            this.razza = razza;
            Vita = 100;
            Exp = 1;
            
        }
        public Razza GetRazza()
        {
            return razza;
        }
        public uint GetExp()
        {
            return Exp;
        }
        public uint GetAttacco()
        {
            return GetRazza().GetAttacco() * GetExp();
        }
        public uint GetDifesa()
        {
            return GetRazza().GetDifesa() * GetExp();
        }

        public override string ToString()
        {
            return ($"{Nome} [Razza:{razza.GetType().Name}]\n Vita : {Vita}\n Esperienza : {Exp}\n Attacco : {razza.GetAttacco()}\n Difesa : {razza.GetDifesa()}\n");
        }
        public bool Attacca(Personaggio p1)
        {
            if (razza.schieramento == p1.razza.schieramento) // tentativo con metodo "PuoiAttaccare" fallito
            {
                throw new Exception("Il personaggio che vuoi attaccare è della tua stessa squadra!");
            }
            else
            {
                uint difesa = p1.Difesa;
                uint attacco = GetAttacco();

                if (attacco>difesa)
                {
                    if (p1.Vita > 0)
                    {
                        p1.Vita--;
                    }
                    if (Exp < 10)
                    {
                        Exp++;
                    }
                    return true;

                }
                else
                {
                    
                    if (p1.Exp < 10)
                    {
                        p1.Exp++;
                    }
                    return false;
                }               
            }
        }

    }
}
