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
                Personaggio p1 = new Personaggio("Alessio",);
                Personaggio p2 = new Personaggio("Mostro", );

                Console.WriteLine($"Il personaggio n.1 è {p1} sta attaccando il personaggio n.2 {p2}");

                Console.WriteLine($"{p1.Attacca(p2)}");

                Console.WriteLine(p1);
                Console.WriteLine(p2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
