using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    internal class Triangulo   : Figura {
        public double Base {  get; set; }
        public double Altura { get; set; }
        public Triangulo() { }

        public Triangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        public double CalculaArea()        {
            return Base * Altura/2;
        }
    }
}
