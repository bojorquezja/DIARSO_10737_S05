using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP
{
    internal class Carro    {
        public string Color { get; set; }
        public string Placa { get; set; }
        public string LicenciaConducir { get; set; }//NO PERTENCE AL CARRO
        
        public Carro() { }

        public void Frenar() { }
        public void Acelerar() { }
        public void GrabarBD() { }//NO PERTENCE AL CARRO
        public void ImprimirPDF() { }//NO PERTENCE AL CARRO
    }
}
