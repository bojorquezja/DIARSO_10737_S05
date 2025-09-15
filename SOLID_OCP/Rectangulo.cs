using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    internal class Rectangulo : Figura   {
        public double Largo {get;set;}
        public double Ancho { get; set; }
        public Rectangulo() { }

        public Rectangulo(double largo, double ancho)        {
            Largo = largo;
            Ancho = ancho;
        }

        public double CalculaArea()        {
            return Largo*Ancho;
        }
    }
}
