using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    internal class CalculadorAreas    {
        public Figura[] listaFig {  get; set; }
        public CalculadorAreas() { }

        public CalculadorAreas(Figura[] listaFig)        {
            this.listaFig = listaFig;
        }
        public void TotalArea()        {
            double tot = 0;
            foreach (var f in listaFig){
                Console.WriteLine(f.CalculaArea());
                tot += f.CalculaArea();
            }
            Console.WriteLine($"TOTAL {tot}");
        }
    }
}
