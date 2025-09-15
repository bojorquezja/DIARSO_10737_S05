using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP
{
    internal class CarroElectrico : Vehiculo
    {
        public void Acelerar()        {
            Console.WriteLine("200 km/h");
        }

        public void EnciendeMotorCombustion()        {
            Console.WriteLine();
            //throw new NotImplementedException();//MAL PORQUE NO DEBE DAR ERROR. MEJOR QUE NO HEREDE DE VEHICULO
        }
    }
}
