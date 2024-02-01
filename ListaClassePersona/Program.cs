using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListaClassePersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> persone = new List<Persona>();
            int c = 0;
            while (c<6)
            {
                persone.Add(Persona.Parse(Console.ReadLine()));
                c++;
            }

            Console.WriteLine("I Maggiorenni sono:");
            foreach (Persona pers in persone)
            {
                if(pers.Età >= 18)
                {
                    Console.WriteLine(pers);
                }
            }

            Console.ReadLine();
        }
    }
}
