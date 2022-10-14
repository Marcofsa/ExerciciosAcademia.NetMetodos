using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosAulasOBJ
{
    internal class lampada
    {
        private bool ligada;
        private double potencia;
        public void ligar()
        {
            ligada = true;
            Console.WriteLine("LIGANDO LÂMPADA.");
        }
        public void desligar()
        {
            ligada = false;
            Console.WriteLine("DESLIGANDO LÂMPADA.");
        }
        public bool estaLigada()
        {
            return ligada;
        }
    }
}
