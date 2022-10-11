using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasOO
{
    public class Carro
    {
        public string marca;
        public string modelo;
        public string placa;

        public Carro(string marca, string modelo, string placa) {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
        }

        public void MostraDados()
        {
            Console.WriteLine("Carro modelo: "+this.modelo+" Fabricante: "+this.marca+" Placa: "+this.placa);
        }

    }
}
