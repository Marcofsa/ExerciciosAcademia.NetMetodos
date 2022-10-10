using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAviao
{
    internal class Aviao
    {
        public string modelo;
        public double velocidade;
        public double altitude;
        public string companhia;

        public void reduzir()
        {
            velocidade -= 10;
            Console.WriteLine("Reduzindo velocidade para " + velocidade);
        }
        public void acelerar()
        {
            velocidade += 10;
            Console.WriteLine("Acelerando velocidade para " + velocidade);
        }
        public void descer()
        {
            altitude -= 100;
            Console.WriteLine("Descendo para " + altitude + " metros...");
        }
        public void subir()
        {
            altitude += 100;
            Console.WriteLine("Subindo para " + altitude + " metros...");
        }
    }
}
