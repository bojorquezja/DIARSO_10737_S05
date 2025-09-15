using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DIP
{
    internal class ImprimePersona    {
        private Persona nom ;
        public ImprimePersona() { }

        public ImprimePersona(Persona nom)
        {
            this.nom = nom;
        }
        public void MuestraNombre()        {
            Console.WriteLine(nom.MiNombre());
        }
    }
}
