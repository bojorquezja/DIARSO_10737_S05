using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DIP
{
    internal class Carlos : Persona   {
        public string Nombre {  get; set; }
        public Carlos() { }
        public Carlos(string nombre) { Nombre = nombre; }

        public string MiNombre()        {
            return Nombre;
        }
    }
}
