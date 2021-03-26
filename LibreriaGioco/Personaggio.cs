using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaGioco
{
    public class Personaggio
    {
        private uint Vita;
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
        public bool Attacca(Personaggio p1)
        {
            if (razza.schieramento == p1.razza.schieramento)
            {
                throw new Exception("Il personaggio che vuoi attaccare è della tua stessa squadra!");
            }
            else
            {
                uint difesa = p1.Difesa;
                uint attacco = GetAttacco();

                if (attacco-difesa < 0) //attacco non andato a buon fine
                {
                    if (Exp < 10)
                    {
                        Exp++;
                    }
                    return false;
                   
                }
                else //attacco andato a buon fine
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
            }
        }

    }
}
