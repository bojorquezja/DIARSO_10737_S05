using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP
{
    internal class CarroGasolina : Vehiculo
    {
        public void Acelerar()        {
            Console.WriteLine("100 km/h");
        }

        public void EnciendeMotorCombustion()        {
            Console.WriteLine("grrrrrrrr");
        }
    }
}
