using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ISP
{
    internal class ImpresoraMatricial : Impresora
    {
        public void CargaCinta()        {
            Console.WriteLine("Insumo cargado");
        }

        public void CargaInsumoLaser()        {
            throw new NotImplementedException();    //No DEBE EXISTIR ESTE METODO
        }

        public void CargaTinta()        {
            throw new NotImplementedException();    //No DEBE EXISTIR ESTE METODO
        }
    }
}
