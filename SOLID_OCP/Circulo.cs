using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    internal class Circulo  : Figura  {
        public double Radio {  get; set; }
        public Circulo() { }
        public Circulo(double radio) { 
            Radio = radio; 
        }
        public double CalculaArea()        {
            return Math.PI*Radio*Radio;
        }
    }
}
