using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasOO
{
    class Estacionamento
    {
        public List<Carro> carros = new List<Carro>();
        public String nome;
        public Estacionamento(string nome)
        {
            this.nome = nome;
            //carros = new List<Carro>();
        }
        //public int[] vet = new int[10];
        public void ArmazenaCarro(String marca, String modelo, String placa)
        {
            Carro c = new Carro(marca, modelo, placa);
            carros.Add(c);  

        }
        public Carro BuscaCarro (String placa)
        {
            Carro r = null;
            foreach (Carro c in carros)
            {
                if (c.placa.Equals(placa))
                {
                    r = c;
                }
            }
            return r;

        }
        public void MostraEstacionados()
        {
            /*for(int i = 0; i < carros.Count; i++)
            {
                Console.WriteLine("Carro "+i+": " + carros[i].modelo);
            }*/

            foreach(Carro c in carros)
            {
                Console.WriteLine("Carro: "+c.modelo+" Fabricante "+c.marca+" Placa: "+c.placa);
            }
        }
        public void RemoveCarro(String placa)
        {
            foreach (Carro c in carros)
            {
                if (c.placa.Equals(placa))
                {
                    //aqui devo apagar o carro da lista
                }
            }
        }
    }
}
