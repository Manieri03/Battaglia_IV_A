using LibreriaGioco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Uomo u1 = new Uomo();
                Troll t1 = new Troll();
                Personaggio p1 = new Personaggio("Alessio", u1 );
                Personaggio p2 = new Personaggio("Mostro", t1);

                Console.WriteLine($"Il personaggio n.1 è {p1.Nome} e sta attaccando il personaggio n.2 {p2.Nome}");

                Console.WriteLine($"{p1.Attacca(p2)}");

                Console.WriteLine("La battaglia si è conclusa, ecco il resoconto dei personaggi:");

                Console.WriteLine(p1.ToString());
                Console.WriteLine(p2.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
