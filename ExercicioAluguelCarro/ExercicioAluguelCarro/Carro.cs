using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAluguelCarro
{
    internal class Carro
    {
        private string placa;
        private string modelo;
        private string color;

        public void setPlaca(string placa)
        {
            this.placa = placa;
        }
        public string getPlaca()
        {
            return placa;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string getModelo()
        {
            return modelo;
        }

        public void setColor()
        {
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }

    }
}
