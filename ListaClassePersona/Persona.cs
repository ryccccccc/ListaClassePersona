using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaClassePersona
{
    internal class Persona
    {
        public string Nome { get; set; }
        public int Età { get; set; }
        public Persona(string name,int age) 
        {
            Nome = name;
            Età = age;
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", Nome, Età);
        }

        public static Persona Parse(string person)
        {
            string[] props = person.Split(',');
            Persona ptemp = new Persona((props[0]), int.Parse(props[1]));
            return ptemp;
        }
    }
}
