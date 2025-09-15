using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ISP
{
    internal interface Impresora    {
        void CargaTinta();  //NO DEBE TENER EL DETALLE EN LA PRINCIPAL
        void CargaCinta();  //NO DEBE TENER EL DETALLE EN LA PRINCIPAL
        void CargaInsumoLaser();    //NO DEBE TENER EL DETALLE EN LA PRINCIPAL
        //A CAMBIO PODRIA TENER UNA INTERFAZ POR CADA TIPO DE IMPRESORA
        //O PODRIA TENER SOLO EL METODO CargaInsumo()
        void Imprimir();    //ESTE OK
    }
}
